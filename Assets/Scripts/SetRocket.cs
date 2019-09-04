using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRocket : MonoBehaviour
{
    public GameObject Rocket;
    // Start is called before the first frame update
    void Start()
    {
        SetUp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetUp()
    {
        Vector2 tempPosition = new Vector2(0, -4);
        GameObject rocket = Instantiate(Rocket, tempPosition, Quaternion.identity) as GameObject;
    }
}
