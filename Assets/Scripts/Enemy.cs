using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speedEnemy;

    void Start()
    {
        Destroy(gameObject, 7f);
    }

    void Update()
    {
        transform.Translate(Vector3.down * speedEnemy * Time.deltaTime, Space.World);
    }
}
