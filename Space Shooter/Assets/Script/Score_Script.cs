using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Script : MonoBehaviour
{

    private static GameObject txtScore;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
        txtScore = GameObject.Find("txtScore");
    }

    // Update is called once per frame
    public static void ScoreUpdate(int a)
    {
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + a);
        txtScore.GetComponent<Text>().text = "Score: " + PlayerPrefs.GetInt("score");
    }

}
