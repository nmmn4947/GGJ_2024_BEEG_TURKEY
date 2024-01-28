using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Baby : Interactable
{
    Placeable _place;
    Room _room;
    Random_kid_want _data;

    public int babyData;
    //1 item
    //2 room

    private void Start()
    {
        _room = GetComponent<Room>();
        _place = GetComponent<Placeable>();
        _data = GetComponent<Random_kid_want>();
        //Start game set active both GameObject = false
    }

    public int getType()
    {
        if (_data.getWant() == Random_kid_want.KidWant.toilet || 
            _data.getWant() == Random_kid_want.KidWant.horsey ||
            _data.getWant() == Random_kid_want.KidWant.bed ||
            _data.getWant() == Random_kid_want.KidWant.station)
        {
            babyData = (int)_data.getWant();
            return (int)_data.getWant();
        }
        else
        {
            babyData = (int)_data.getWant();
            return (int)_data.getWant();
        }
    }
}