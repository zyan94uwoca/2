using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class changedeath : MonoBehaviour
{
    public TextMeshProUGUI thirdname;
    public static int input=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         input = GameManager.restarttime;
         thirdname.text = input.ToString();
    }
}
