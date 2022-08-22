using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event4 : MonoBehaviour
{
    public Rigidbody2D m;
    public float speed = -10f;
    public GameObject ppp;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {


            Vector2 v = new Vector2(speed, 0);
            m.velocity = v;
            Destroy(ppp, 2);
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
