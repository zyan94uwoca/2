using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event5 : MonoBehaviour
{

    public Rigidbody2D m;
    public float speed = 20f;
    public GameObject ppp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {

            GameObject a = GameObject.Find("Event4");
            if (a == null)
            {
                Vector2 ve = new Vector2(0, speed);
                m.velocity = ve;
                Destroy(ppp, 4);
                Destroy(gameObject);
            }
            
        }
    }
}
