using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject prefabExplosion;
    GameState gameState;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && gameObject.tag != "Enemy" && (collision.gameObject.tag == "Enemy" && gameObject.tag != "Player") && gameState == GameState.Play)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Boom();

            if(GameOver.isGameOver == false)
            {
                Score.score += 1;
            }
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
        Destroy(Instantiate(prefabExplosion, transform.position, Quaternion.identity), 1f);
    }
}
