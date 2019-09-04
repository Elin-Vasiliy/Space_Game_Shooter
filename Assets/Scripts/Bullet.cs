using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject parent;
    public GameObject Parent { set { parent = value; } get { return parent; } }

    [SerializeField] private float Speed;

    private Vector3 direction;
    public Vector3 Direction { set { direction = value; } }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.5F);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position + direction, Speed * Time.deltaTime);
    }

    //private void OnTriggerEnter2D(Collider2D collider)
    //{
    //    RocketControl rocketControl = collider.GetComponent<RocketControl>();

    //    if (rocketControl && rocketControl.gameObject != parent)
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
