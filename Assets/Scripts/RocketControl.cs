using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControl : MonoBehaviour
{
    [Header("Bullet")]
    public GameObject bulletSet;
    private bool isBullet = false;
    private float SpeedBullet = 1f;

    private float updateTime = 0f;

    [SerializeField] GameObject prefabBoom;
    private Vector2 firstPosition;
    private Vector2 finishPosition;
    new private Rigidbody2D rigidbody;

    void Start()
    {

    }

    private void FixedUpdate()
    {
        if (isBullet == true && updateTime < 0)
        {
            Shoot();
            updateTime = 1f;
        }
        else
        {
            updateTime -= Time.deltaTime;
        }
    }

    private void Awake()
    {

    }



    private void OnMouseDrag()
    {
        isBullet = true;
        firstPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = firstPosition;
        RocketPosition();

    }

    private void OnMouseUp()
    {
        isBullet = false;
    }



    void RocketPosition()
    {
        if (transform.position.x > 2)
        {
            transform.position = new Vector2(2, transform.position.y);
            if (transform.position.y < -4)
            {
                transform.position = new Vector2(2, -4);
            }
            else if (transform.position.y > 4)
            {
                transform.position = new Vector2(2, 4);
            }
        }
        else if (transform.position.x < -2)
        {
            transform.position = new Vector2(-2, transform.position.y);
            if (transform.position.y < -4)
            {
                transform.position = new Vector2(-2, -4);
            }
            else if (transform.position.y > 4)
            {
                transform.position = new Vector2(-2, 4);
            }
        }
        else if (transform.position.y < -4)
        {
            transform.position = new Vector2(transform.position.x, -4);
        }
        else if (transform.position.y > 4)
        {
            transform.position = new Vector2(transform.position.x, 4);
        }


    }

    private void Shoot()
    {

        Vector3 position = transform.position;
        GameObject newBullet = Instantiate(bulletSet, position, Quaternion.identity) as GameObject;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Explosion();
        }
    }

    void Explosion()
    {
        Destroy(Instantiate(prefabBoom, transform.position, Quaternion.identity), 1f);
    }
}
