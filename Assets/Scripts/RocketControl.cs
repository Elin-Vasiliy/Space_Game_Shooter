using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControl : MonoBehaviour
{
    private Bullet bullet;
    private Vector2 firstPosition;
    private Vector2 finishPosition;
    // Start is called before the first frame update
    void Start()
    {
        bullet = Resources.Load<Bullet>("Bullet");
    }    

    private void OnMouseDrag()
    {
        firstPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = firstPosition;
        RocketPosition();
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

        Shoot();
    }

    private void Shoot()
    {
        Vector2 position = transform.position;
        position.y += 0.5f;

        Bullet newBullet = Instantiate(bullet, position, bullet.transform.rotation) as Bullet;

        newBullet.Parent = gameObject;
        newBullet.Direction = newBullet.transform.up;
    }
}
