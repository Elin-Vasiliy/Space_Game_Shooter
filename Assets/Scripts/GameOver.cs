using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text txtGameOver;
    [SerializeField] private GameObject prefabBack;
    [SerializeField] private Text textScore;
    private Points points;
    private bool isGameOver;

    private void Start()
    {
        points = FindObjectOfType<Points>();
    }

    private void Update()
    {
        if (isGameOver == true && points.isNewRecord == false)
        {
            txtGameOver.text = $"Game Over" ;
            textScore.text = $"Score \n{points.score}";
            SetUp();
        }
        else if(isGameOver == true && points.isNewRecord == true)
        {
            txtGameOver.text = $"Game Over";
            textScore.text = $"New Record \n{points.score}";
            SetUp();
        }
    }

    public void Over(bool isGame)
    {
        isGameOver = isGame;
    }

    private void SetUp()
    {
        Vector2 temp = new Vector2(0, -1);
        GameObject back = Instantiate(prefabBack, temp, Quaternion.identity) as GameObject;
    }
}
