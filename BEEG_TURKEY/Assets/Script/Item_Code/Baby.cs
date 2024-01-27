using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : Interactable
{
    Placeable _place;
    Room _room;

    public int babyData;
    //1 item
    //2 room



    private void Start()
    {
        _room = GetComponent<Room>();
        _place = GetComponent<Placeable>();
        //Start game set active both GameObject = false
        babyData = 1;
    }



    public override void Interact()
    {

    }
}