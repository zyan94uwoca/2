using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event10 : MonoBehaviour
{
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
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



            Destroy(gameObject);

        }
    }
}
