using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
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
        sprite.enabled = false;
    }

    public void EnableSprite()
    {
        sprite.enabled = true;
    }

}
