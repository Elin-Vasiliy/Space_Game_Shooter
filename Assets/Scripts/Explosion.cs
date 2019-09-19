﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject prefabExplosion;
    GameState gameState;
    private int scoreUp;
    private Points points;
    
    void Start()
    {
        GameObject PointsObject = GameObject.FindGameObjectWithTag("Score");
        if (PointsObject != null)
        {
            points = PointsObject.GetComponent<Points>();
        }
        else if (PointsObject == null)
        {
            Debug.Log("Ненайдено");
        }

        scoreUp = 0;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && gameObject.tag != "Enemy" && (collision.gameObject.tag == "Enemy" && gameObject.tag != "Player") && gameState == GameState.Play)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Boom();
            

            points.Score(scoreUp);
        }
        else if(collision.gameObject.tag == "Enemy" && gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Boom();
        }
    }

    private void Boom()
    {
        scoreUp += 10;
        Destroy(Instantiate(prefabExplosion, transform.position, Quaternion.identity), 1f);
    }
}
