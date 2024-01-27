using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : Interactable
{
    Placeable place;
    // Start is called before the first frame update
    void Start()
    {
        place = GetComponent<Placeable>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Interact()
    {
        place.DisableSprite();
    }
}
