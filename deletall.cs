using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void delete()
    {
        PlayerPrefs.SetString("name1", "null");
        PlayerPrefs.SetString("name2", "null");
        PlayerPrefs.SetString("name3", "null");
        PlayerPrefs.SetFloat("score1", float.PositiveInfinity);
        PlayerPrefs.SetFloat("score2", float.PositiveInfinity);
        PlayerPrefs.SetFloat("score3", float.PositiveInfinity);
    }
}
