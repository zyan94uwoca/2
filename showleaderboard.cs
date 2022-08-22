using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showleaderboard : MonoBehaviour
{
    public TextMeshProUGUI firstname;
    public TextMeshProUGUI firstscore;

    public TextMeshProUGUI secondname;
    public TextMeshProUGUI secondscore;

    public TextMeshProUGUI thirdname;
    public TextMeshProUGUI thirdscore;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("name1"))
        {
            PlayerPrefs.SetString("name1", "null");
            PlayerPrefs.SetString("name2", "null");
            PlayerPrefs.SetString("name3", "null");
            PlayerPrefs.SetFloat("score1", float.PositiveInfinity);
            PlayerPrefs.SetFloat("score2", float.PositiveInfinity);
            PlayerPrefs.SetFloat("score3", float.PositiveInfinity);
        }
            firstname.text = PlayerPrefs.GetString("name1");
            secondname.text = PlayerPrefs.GetString("name2");
            thirdname.text = PlayerPrefs.GetString("name3");
            firstscore.text = PlayerPrefs.GetInt("score1") + "";
            secondscore.text = PlayerPrefs.GetInt("score2") + "";
            thirdscore.text = PlayerPrefs.GetInt("score3") + "";
        
        
    }

        // Update is called once per frame
        void Update()
        {
        firstname.text = PlayerPrefs.GetString("name1");
        secondname.text = PlayerPrefs.GetString("name2");
        thirdname.text = PlayerPrefs.GetString("name3");
        firstscore.text = PlayerPrefs.GetFloat("score1") + "";
        secondscore.text = PlayerPrefs.GetFloat("score2") + "";
        thirdscore.text = PlayerPrefs.GetFloat("score3") + "";
    }
    
}
