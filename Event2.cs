using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event2 : MonoBehaviour
{
    public Rigidbody2D m;
    public float speed = -10f;
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


            Vector2 v = new Vector2(0, speed);
            m.velocity = v;
            Destroy(ppp, 4);
            Destroy(gameObject);
        }
    }
}
