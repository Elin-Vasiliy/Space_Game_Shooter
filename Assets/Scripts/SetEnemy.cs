using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] Enemys;
    private static int numbers = 0;
    private float timeUpdate;

    void Update()
    {
        float rndTime = Random.Range(0.5f, 0.5f);

        if(timeUpdate < 0)
        {
            Set();
            timeUpdate = rndTime;
        }
        else
        {
            timeUpdate -= Time.deltaTime;
        }
    }

    private void Set()
    {
        var rndEnemy = Random.Range(0, Enemys.Length);
        Vector2 rndVector = new Vector2(Random.Range(-2.5f, 2.5f), 5.5f);
        GameObject enemy = Instantiate(Enemys[rndEnemy], rndVector, Quaternion.identity) as GameObject;
        numbers++;
        enemy.name = (numbers).ToString();
    }
}
