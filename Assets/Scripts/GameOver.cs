using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text txtGameOver;
    [SerializeField] private GameObject prefabBack;
    [SerializeField] private Text textScore;
    public static bool isGameOver = false;
    private bool isBack = false;

    private void Start()
    {
        isGameOver = false;
    }

    private void Update()
    {
        if (isGameOver == true && isBack == false)
        {
            txtGameOver.text = $"Game Over \n{Score.score}";
            SetUp();
            isBack = true;
        }
    }

    private void SetUp()
    {
        Vector2 temp = new Vector2(0, -1);
        GameObject back = Instantiate(prefabBack, temp, Quaternion.identity) as GameObject;
    }
}
