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
    PickUpBaby pickupbaby;
    [SerializeField] private InteractWithObject _player;
    [SerializeField] private int item_ID;
    Shaker shaker;
    Doll doll;
    Car car;


    public override void Awake()
    {
        base.Awake();
        _player = FindAnyObjectByType<InteractWithObject>();
        place = GetComponent<Placeable>();
        room = GetComponent<Room>();
        baby = GetComponent<Baby>();
        pickupbaby = GetComponent<PickUpBaby>();
        shaker = GetComponentInChildren<Shaker>();
        doll = GetComponentInChildren<Doll>();
        car = GetComponentInChildren<Car>();

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
            
            if (someThing.Contains(item_ID))
            {
                Debug.Log("Want something");
                if (_player.GetComponent<InteractWithObject>().putbackItem(item_ID))
                {
                    Debug.Log("Item is match");
                    if (item_ID == 1)
                    {
                        shaker.yes = true;
                    }
                    else if (item_ID == 2)
                    {
                        doll.yes = true;
                    }
                    else if (item_ID == 3)
                    {
                        car.yes = true;
                    }
                }
                else
                {
                    Debug.Log("Item is not match");

                    
                }
            }
            else if (someWhere.Contains(item_ID))
            {
                Debug.Log("Want somewhere");
                //room.DisableSprite();
                pickupbaby.isPickedUp = true;
                _player.GetComponent<InteractWithObject>().pickupItem(item_ID);
            }
            else
            {
                Debug.Log("Bruh");
            }
        }
    }


}
