using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    bool m_isGrounded;
    bool m_isWalled;

    public LayerMask m_groundLayer;
    public float m_groundCheckDistance = 0.7f;

    public Transform m_headCheck;
    public Transform m_footCheck;
    public float m_wallCheckDistance = 0.2f;

    Animator m_anim;
    Rigidbody2D m_body;

    bool m_FacingRight = true;

    public static bool toright;
    public float m_Speed = 200f;
    public float m_jumpForce = 20f;

    bool m_jump;
    int m_jumps;

    public float m_CanJumpTime = 0.2f;
    private float m_JumpTimer;
    private bool m_isJumping;

    private Vector2 m_vec;
    private float m_input_h;

    private int m_jumpTimes;
    public Vector2 bulletspeed = new Vector2(15, 0);


    public GameObject pfb_bullets;

    public GameObject lostUI;

    public AudioClip shoot;
    private void FixedUpdate()
    {
        m_anim.SetFloat("vSpeed", m_body.velocity.y);
       
        m_input_h = Input.GetAxisRaw("Horizontal");
        if (m_input_h != 0)
        {
            m_anim.SetBool("run", true);
        }
        else 
        {
            m_anim.SetBool("run", false);
        }
        Move(m_input_h);
    }
    void Start()
    {
        Screen.fullScreen = false;
        m_anim = GetComponent<Animator>();
        m_body = GetComponent<Rigidbody2D>();
        m_JumpTimer = 0f;
        m_isJumping = false;
        m_vec = new Vector2(0, m_jumpForce);
        m_jumpTimes = 0;
        toright = m_FacingRight;
        lostUI.SetActive(false);
        
    }
   

        
      private void Update()
    {
        
        toright = m_FacingRight;
        m_isGrounded = IsGrounded();
        if (m_anim.GetBool("Ground") != m_isGrounded)
        {
            m_anim.SetBool("Ground", m_isGrounded);
        }

        

        if (m_isJumping && Input.GetKey(KeyCode.Space))

        {
            if (m_JumpTimer <= m_CanJumpTime)
            {
                m_vec.x = m_body.velocity.x;
                m_body.velocity = m_vec;
                m_JumpTimer += Time.deltaTime;
                
            }
            else
            {
                m_isJumping = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (m_isGrounded||m_jumpTimes==0)
            {
                m_jumpTimes =1;
                m_isJumping = true;
                m_JumpTimer = 0f;
                m_isGrounded = false;
                m_vec.x = m_body.velocity.x;
                m_body.velocity = m_vec;
            }
            else if (m_jumpTimes == 1 && m_body.velocity.y<=0 )
            {
                m_jumpTimes = 2;
                m_isJumping = true;
                m_JumpTimer = 0f;
                m_isGrounded = false;
                m_vec.x = m_body.velocity.x;
                m_body.velocity = m_vec;
            }
        }
        
        if (Input.GetKeyUp(KeyCode.Space) && m_isGrounded)
        {
            m_isJumping = false;
            if (m_jumpTimes == 2)
            {
                m_jumpTimes = 0;
            }
            
        }
        //m_anim.SetFloat("vSpeed", m_body.velocity.y);
        //m_anim.SetBool("run", true);
        // m_input_h = Input.GetAxisRaw("Horizontal");
        // Move(m_input_h);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            
            GameObject p = Instantiate(pfb_bullets,transform.position,Quaternion.identity);
            p.GetComponent<Rigidbody2D>().velocity = m_FacingRight?bulletspeed:-1*bulletspeed;
        }
    }

    private void Move(float h)
    {
        m_isWalled = isWall(m_FacingRight ? 1 : -1);
        if (m_FacingRight)
        {
            if (h < 0)
            {
                Flip();
            }
            else if(m_isWalled)
            {
                m_anim.SetBool("run", false);
                return;
            }
        }
        
        else
        {
            if (h > 0)
            {
                Flip();
            }
            else if (m_isWalled)
            {
                
                m_anim.SetBool("run", false);
                return;
            }
        }
        Vector2 v = m_body.velocity;
        v.x = h * m_Speed * Time.deltaTime;
        m_body.velocity = v;
        


    }
    void Flip()
        {
        m_FacingRight = !m_FacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        toright = m_FacingRight;
    }
     bool IsGrounded()
    {
        Debug.DrawRay(transform.position, Vector2.down, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(m_footCheck.position, Vector2.down, m_groundCheckDistance, m_groundLayer);
        
        if (hit.collider != null)
        {
            return true;
        }
        return false;
        
    }
    bool isWall(float dir)
    {
        RaycastHit2D hit1 = Physics2D.Raycast(m_headCheck.position, dir * Vector2.right, m_wallCheckDistance, m_groundLayer);
        RaycastHit2D hit2 = Physics2D.Raycast(m_footCheck.position, dir * Vector2.right, m_groundCheckDistance, m_groundLayer);
        if ((hit1.collider == null) && (hit2.collider == null))
        {
            return false;
        }
        return true;
    }
    void bedamage()
    {
        lostUI.SetActive(true);
        
        
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(shoot, transform.position);
    }

   

    
    
}
    
