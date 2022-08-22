using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitUiControl : MonoBehaviour
{
    bool ESC = false;
    public GameObject EXIT;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        EXIT.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ESC == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 1;
                ESC = false;
                EXIT.SetActive(false);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                ESC = true;
                EXIT.SetActive(true);
            }

        }
    }
    public void Exit()
    {
        Application.Quit();
        Time.timeScale = 1;

    }
    public void Back()
    {

        EXIT.SetActive(false);
        Time.timeScale = 1;
    }
   public void backtostart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
    public void restart()
    {   
        PlayerPrefs.SetFloat("PlayerX", (float)-24.48);
        PlayerPrefs.SetFloat("PlayerY", (float)-2.61);
        PlayerPrefs.SetFloat("PlayerZ", 0);
        Time.timeScale = 1;
        GameManager.restarttime = 0;
        PlayerPrefs.SetInt("pos", 0);
        SceneManager.LoadScene(1);
    }

}
