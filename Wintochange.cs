using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Wintochange : MonoBehaviour
{
    public float one;
    public float two;
    public float three;


    public string user1;
    public string user2;
    public string user3;


    public GameObject player;
    public GameObject show;
    public static int deths = changedeath.input;
    public TextMeshProUGUI firstname;
    public TMP_InputField c;
    private string input;
    public static int dorwork;

    // Start is called before the first frame update
    void Start()
    {
        dorwork = 0;

        show.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ReadStringInput()
    {
        dorwork = changedeath.input;
        input = c.text;
        PlayerPrefs.SetInt("deths", deths);
        PlayerPrefs.SetString("Playername", input);
        Time.timeScale = 1;
        Debug.Log(PlayerPrefs.GetString("name1"));
        
        
        SceneManager.LoadScene(0);
        PlayerPrefs.SetFloat("PlayerX", (float)-24.48);
        PlayerPrefs.SetFloat("PlayerY", (float)-2.61);
        PlayerPrefs.SetFloat("PlayerZ", 0);
        Time.timeScale = 1;
        GameManager.restarttime = 0;
        PlayerPrefs.SetInt("pos", 0);
        SceneManager.LoadScene(1);


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {


            dorwork = 1;
            
            Time.timeScale = 0;
            show.SetActive(true);

        }
    }
    public void changes()
    {
        
        one = PlayerPrefs.GetFloat("score1");
        two = PlayerPrefs.GetFloat("score2");
        three = PlayerPrefs.GetFloat("score3");

        user1 = PlayerPrefs.GetString("name1");
        user2 = PlayerPrefs.GetString("name2");
        user3 = PlayerPrefs.GetString("name3");
      
        if (dorwork < three)
        {
            if (dorwork >= one)
            {

                if (dorwork >= two)
                {
                    PlayerPrefs.SetFloat("score3", dorwork);
                    PlayerPrefs.SetString("name3", input);
                }
                else
                {
                    PlayerPrefs.SetFloat("score3", two);
                    PlayerPrefs.SetString("name3", user2);
                    PlayerPrefs.SetFloat("score2", dorwork);
                    PlayerPrefs.SetString("name2", input);
                }

            }
            else
            {
                PlayerPrefs.SetFloat("score3", two);
                PlayerPrefs.SetString("name3", user2);
                PlayerPrefs.SetFloat("score2", one);
                PlayerPrefs.SetString("name2", user1);
                PlayerPrefs.SetFloat("score1", dorwork);
                PlayerPrefs.SetString("name1", input);
            }
        }
        
    }

    
}
