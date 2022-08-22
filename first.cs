using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class first : MonoBehaviour
{
    
    public GameObject Startmenu;
    public GameObject boards;
    
    public bool isfinish = false;
    public static bool isstart;
    public bool ppp = false;
    int over = 0;
    void Start()
    {
        boards.SetActive(false);
        
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (ppp)
        {
            isstart = true;
        }

    }
    public void plays()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();

    }
    public void board()
    {
        boards.SetActive(true);
        Startmenu.SetActive(false);


    }
    public void exittheboard()
    {
        boards.SetActive(false);
        Startmenu.SetActive(true);
    }

}
