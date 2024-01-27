using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Item : Interactable
{
    Placeable place;
    Room room;
    Baby baby;
    [SerializeField] private GameObject _player;
    [SerializeField] private int item_ID;

    public override void Awake()
    {
        base.Awake();
        place = GetComponent<Placeable>();
        room = GetComponent<Room>();
        baby = GetComponent<Baby>();
    }

    public override void Interact()
    {
        int[] someThing = Enumerable.Range(1, 4).ToArray();
        int[] someWhere = Enumerable.Range(4, 6).ToArray();
        if (baby == null)
        {
            Debug.Log("This is Item");
            place.DisableSprite();
            _player.GetComponent<InteractWithObject>().pickupItem(item_ID);
        }       
        else if(baby != null)
        {
            Debug.Log("This is baby");
            item_ID = baby.getType();
            Debug.Log(item_ID);
            if (someThing.Contains<int>(item_ID))
            {
                Debug.Log("Want something");
                if (_player.GetComponent<InteractWithObject>().putbackItem(item_ID))
                {
                    Debug.Log("Item is match");
                }
                else
                {
                    Debug.Log("Item is not match");
                }
            }
            else if (someWhere.Contains<int>(item_ID))
            {
                Debug.Log("Want somewhere");
                room.DisableSprite();
                _player.GetComponent<InteractWithObject>().pickupItem(item_ID);
            }
        }
    }


}
