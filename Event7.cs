using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event7 : MonoBehaviour
{


    
    
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


                Vector3 ve = ppp.transform.position;
            ve.x = ve.x + (float)0.8;
                ppp.transform.position = ve;
                
                Destroy(gameObject);
            

        }
    }
}
