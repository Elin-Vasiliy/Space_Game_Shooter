using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    [SerializeField] private Text txt;
    private int score;

    private RocketControl rocketControl;

    void Start()
    {
        score = 0;
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

    
}
