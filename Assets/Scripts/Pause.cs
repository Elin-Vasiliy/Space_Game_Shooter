using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private Sprite[] sprite;
    public bool pauseBool = false;
    
    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite[0];
        pauseBool = false;
    }

    private void OnMouseDown()
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
