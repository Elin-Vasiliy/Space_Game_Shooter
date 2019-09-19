using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRocket : MonoBehaviour
{
    [SerializeField] private GameObject Rocket;

    

    void Awake()
    {
        SetUp();
    }

    void SetUp()
    {
        Vector2 tempPosition = new Vector2(0, -4);
        GameObject rocket = Instantiate(Rocket, tempPosition, Quaternion.identity) as GameObject;
    }
}
