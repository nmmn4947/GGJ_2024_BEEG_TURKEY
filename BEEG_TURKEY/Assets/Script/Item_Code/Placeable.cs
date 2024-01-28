using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeable : MonoBehaviour
{
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableSprite()
    {
        Debug.Log(sprite);
        sprite.enabled = false;
    }

    public void EnableSprite()
    {
        sprite.enabled = true;
    }


}
