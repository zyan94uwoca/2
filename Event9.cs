using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event9 : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
        b.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {

            a.SetActive(true);
            b.SetActive(true);
            Destroy(a, 1);
            Destroy(b, 1);
            Destroy(gameObject);

        }
    }
}
