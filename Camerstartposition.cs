using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerstartposition : MonoBehaviour
{
    public static int place = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        int ppp = PlayerPrefs.GetInt("pos", 0);
        if (ppp == 0)
        {

        }
        else if (ppp == 1)
        {
            Vector3 ve = new Vector3((float)16.21, (float)0.25, -10);
            gameObject.transform.position = ve;
            
        }
        else if (ppp == 2)
        {
            Vector3 ve = new Vector3((float)32.965, (float)0.25, -10);
            gameObject.transform.position = ve;
        }
        else if (ppp == 3)
        {
            Vector3 ve = new Vector3((float)49.72, (float)0.25, -10);
            gameObject.transform.position = ve;
        }
        else if (ppp == 4)
        {
            Vector3 ve = new Vector3((float)66.475, (float)0.25, -10);
            gameObject.transform.position = ve;
        }
        else if (ppp == 5)
        {
            Vector3 ve = new Vector3((float)66.475, (float)-16.75, -10);
            gameObject.transform.position = ve;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
