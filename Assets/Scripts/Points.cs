using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

    [SerializeField] private Text txt;
    private GameObject rocket;
    public int score;
    public int record;
    public bool isNewRecord = false;
    private bool isSave = false;

    void Start()
    {
        rocket = GameObject.FindGameObjectWithTag("Player");
        score = 0;
    }

    private void Update()
    {
        if(score > record)
        {
            PlayerPrefs.SetInt("saveScore", score);
            PlayerPrefs.Save();
            isSave = true;
        }

        record = PlayerPrefs.GetInt("saveScore");

        NewRecord();
    }

    void UpdateScore()
    {
        txt.text = $"Счет: {score.ToString()}";
    }

    public void Score(int point)
    {
        score += point;
        UpdateScore();
    }

    private void NewRecord()
    {
        if(rocket == null && isSave == true)
        {
            isNewRecord = true;
        }
    }

}
