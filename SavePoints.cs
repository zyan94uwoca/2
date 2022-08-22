using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoints : MonoBehaviour
{
    public Sprite m_save;
    SpriteRenderer m_spriteRender;
    public int set;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        m_spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Beshot()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);
        m_spriteRender.sprite = m_save;
        
        PlayerPrefs.SetInt("pos", set);



    }
}
