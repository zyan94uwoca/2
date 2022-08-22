using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prickTriggerNo : MonoBehaviour
{
    public GameObject ccc;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(ccc);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
