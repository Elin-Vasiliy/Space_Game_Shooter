using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    [SerializeField] private Text textRecord;
    private Points points;

    void Start()
    {
        points = GameObject.FindObjectOfType<Points>();
    }

    private void Update()
    {
        SetUp();
    }

    private void SetUp()
    {
        textRecord.text = $"Record {PlayerPrefs.GetInt("saveScore").ToString()}";
    }
}
