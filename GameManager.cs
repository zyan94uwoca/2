using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject m_player;
    public static int restarttime = 0;
    public static int numberscence = 0;
    public static int rwork = Wintochange.dorwork;
    // Start is called before the first frame update
    void Start()
    {
        float x = PlayerPrefs.GetFloat("PlayerX", (float)-24.02);
        float y = PlayerPrefs.GetFloat("PlayerY", (float)-2.3);
        float z = PlayerPrefs.GetFloat("PlayerZ", 0);
        m_player.transform.position = new Vector3(x, y, z);
        

        
    }

    // Update is called once per frame
    void Update()
    {    rwork = Wintochange.dorwork;
         
        if (Input.GetKeyDown(KeyCode.R)&& rwork!=1)
        {
            restarttime++;
            
            SceneManager.LoadScene(1);
           
        }
    }
}
