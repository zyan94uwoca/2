using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event8 : MonoBehaviour
{
    public GameObject ppp;
    // Start is called before the first frame update
    void Start()
    {
        ppp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            ppp.SetActive(true);

            
            
            
            Destroy(gameObject);
        }
    }

}
