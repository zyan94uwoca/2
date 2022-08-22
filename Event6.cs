using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event6 : MonoBehaviour
{
    public Rigidbody2D m1;
    public Rigidbody2D m;
    public float speed = 10f;
    public float speed1 = 10f;
    public GameObject ppp;
    public GameObject ppp1;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {


            Vector2 v = new Vector2(speed, 0);
            Vector2 v1 = new Vector2(-speed1, 0);
            m.velocity = v;
            m1.velocity = v1;
            Destroy(ppp, 4);
            Destroy(ppp1, 4);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
