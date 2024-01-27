using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Item : Interactable
{
    Placeable place;
    Room room;
    Baby baby;
    // Start is called before the first frame update
    public override void Awake()
    {

        base.Awake();
        place = GetComponent<Placeable>();
        room = GetComponent<Room>();
        baby = GetComponent<Baby>();
    }

    // Update is called once per frame
    public override void Interact()
    {
        if(baby == null)
        {
            Debug.Log("This is Item");
        }       
        else if(baby != null)
        {
            Debug.Log("This is baby");
            place.enabled = true;
            room.enabled = true;
            if (baby.babyData == 1)
            {
                Debug.Log("Want something");
            }
            else if (baby.babyData == 2)
            {
                Debug.Log("Want somewhere");
            }
        }
    }


}
