using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    public GameObject gameob;
    public GameObject player;
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

            Vector3 ve = gameob.transform.position;
            
            
             if(!playercontrol.toright)
            {
             ve.x = (float)(ve.x - 16.755);
             }

            gameob.transform.position = ve;


        }
    }
}
