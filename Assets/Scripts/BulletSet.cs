using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSet : MonoBehaviour
{
    [SerializeField] private GameObject prefabBoom;
    private float Speed = 10f;

    private void Start()
    {
        Destroy(gameObject, 1.4f);
    }

    private void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Boom();
        }
        
    }

    private void Boom()
    {
        Destroy(Instantiate(prefabBoom, transform.position, Quaternion.identity), 1f);
    }

}
