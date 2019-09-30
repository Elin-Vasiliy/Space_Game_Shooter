using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text txt;
    public static int score;
    public int record;

    private void Awake()
    {
        score = 0;
    }

    private void Update()
    {
        txt.text = $"Score: {score.ToString()}";
        if (score > record)
        {
            PlayerPrefs.SetInt("saveScore", score);
            PlayerPrefs.Save();
        }

        record = PlayerPrefs.GetInt("saveScore");
    }
}
