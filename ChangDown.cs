using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangDown : MonoBehaviour
{
    public GameObject gameob;
    public GameObject player;
    public static bool pointto;
    public int space = 9;
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
            
            
                ve.y = (float)(ve.y - space);
            
            //else if(player.transform.position.x<gameob.transform.position.x-6.45)
            //{
            // ve.x = (float)(ve.x - 14);
            // }

            gameob.transform.position = ve;


        }
    }
}
