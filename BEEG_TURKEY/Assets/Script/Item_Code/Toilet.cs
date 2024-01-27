using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : Interactable
{
    Placeable place;
    // Start is called before the first frame update
    public override void Awake()
    {

        base.Awake();
        place = GetComponent<Placeable>();
    }

    // Update is called once per frame
    public override void Interact()
    {
        
        place.DisableSprite();
    }


}
