using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool pauseBool = false;
    [SerializeField] private Sprite[] sprite;

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite[0];
        pauseBool = false;
    }

    public void OnMouseDown()
    {
        if(pauseBool == false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite[1];
            pauseBool = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite[0];
            pauseBool = false;
        }
        
    }
}
