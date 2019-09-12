﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControl : MonoBehaviour
{
    [Header("Bullet")]
    public GameObject bulletSet;
    private bool isBullet = false;
    private float SpeedBullet = 1f;

    private float updateTime = 0f;
    GameState gameState = GameState.Play;

    [SerializeField] GameObject prefabBoom;
    private Vector2 firstPosition;
    private Vector2 finishPosition;
    new private Rigidbody2D rigidbody;



    void Start()
    {
        gameState = GameState.Play;
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

    private void Update()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = 2;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
        RocketPosition();
        if (Input.GetButtonDown("Fire1")) isBullet = true;
    }

    private void OnMouseUp()
    {
        isBullet = false;
    }


    void RocketPosition()
    {
        if (transform.position.x > 2.5f)
        {
            transform.position = new Vector2(2.5f, transform.position.y);
            if (transform.position.y < -4.5f)
            {
                transform.position = new Vector2(2.5f, -4.5f);
            }
            else if (transform.position.y > 4)
            {
                transform.position = new Vector2(2.5f, 4);
            }
        }
        else if (transform.position.x < -2.5f)
        {
            transform.position = new Vector2(-2.5f, transform.position.y);
            if (transform.position.y < -4)
            {
                transform.position = new Vector2(-2.5f, -4);
            }
            else if (transform.position.y > 4)
            {
                transform.position = new Vector2(-2.5f, 4);
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
            gameState = GameState.GameOver;
            Destroy(gameObject);
            Destroy(other.gameObject);
            Explosion();
        }
    }

    void Explosion()
    {
        Destroy(Instantiate(prefabBoom, transform.position, Quaternion.identity), 1f);
    }

    public enum GameState
    {
        Play,
        GameOver,
        Pause
    }

}
