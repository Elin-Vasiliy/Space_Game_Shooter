using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSet : MonoBehaviour
{
    private SpriteRenderer sprite;

    private float Speed = 10f;
    //private Vector3 direction;
    //public Vector3 Direction { set { direction = value; } }

    private void Start()
    {
        Destroy(gameObject, 1.4f);
    }

    private void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime, Space.World);
    }


}
