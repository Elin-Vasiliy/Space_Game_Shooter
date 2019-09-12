using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class BulletSet : MonoBehaviour
{
    Text text;
    public int scoreUp;

    [SerializeField] private GameObject prefabBoom;
    private float Speed = 10f;

    private Points points;

    private void Start()
    {
        GameObject PointsObject = GameObject.FindGameObjectWithTag("Text");
        if(PointsObject != null)
        {
            points = PointsObject.GetComponent<Points>();
        }
        else if(PointsObject == null)
        {
            Debug.Log("Ненайдено");
        }
        scoreUp = 0;
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

            points.Score(scoreUp);


        }
    }

    private void Boom()
    {
        scoreUp++;
        Destroy(Instantiate(prefabBoom, transform.position, Quaternion.identity), 1f);
    }
}
