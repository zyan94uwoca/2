using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event11 : MonoBehaviour
{
    public GameObject ppp;
    public GameObject ppp1;
    public GameObject ppp2;
    // Start is called before the first frame update
    void Start()
    {
        ppp.SetActive(false);
        ppp1.SetActive(false);
        ppp2.SetActive(false);
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
            ppp1.SetActive(true);
            ppp2.SetActive(true);


            Destroy(gameObject);
        }
    }
}
