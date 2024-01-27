using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ItemResource : Interactable
{
    Room room;
    [SerializeField] private int source_ID;
    [SerializeField] private GameObject player;

    public override void Awake()
    {
        base.Awake();
        room = GetComponent<Room>();
    }

    public override void Interact()
    {
        int itemFromPlayer = player.GetComponent<InteractWithObject>()._itemID;
        Debug.Log(itemFromPlayer);
        Debug.Log("------------");
        Debug.Log(source_ID);
        if(itemFromPlayer == 0)
        {
            player.GetComponent<InteractWithObject>().pickupItem(source_ID);
        }
        else if (itemFromPlayer == source_ID)
        {
            Debug.Log("Item put back the soure item.");
            player.GetComponent<InteractWithObject>().putbackItem(itemFromPlayer);
        }
        else
        {
            Debug.Log("Item can't put back the soure item.");
        }
    }
}
