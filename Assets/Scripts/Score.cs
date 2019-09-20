using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    GameObject Hero;
    public int score;

    void Start()
    {
        Hero = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), $"Score: {score}");
    }
}
