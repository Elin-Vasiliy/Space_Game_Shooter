using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class BulletSet : MonoBehaviour
{
    private float speed = 10f;

    private void Start()
    {
        Destroy(gameObject, 1.4f);
    }

    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
    }
}
