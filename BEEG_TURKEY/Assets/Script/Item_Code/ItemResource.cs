using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ItemResource : Interactable
{
    Room room;
    [SerializeField] private int source_ID;
    [SerializeField] private InteractWithObject player;

    public override void Awake()
    {
        base.Awake();
        room = GetComponent<Room>();
        player = FindAnyObjectByType<InteractWithObject>();
    }

    public override void Interact()
    {
        int itemFromPlayer = player._itemID;
        Debug.Log(itemFromPlayer);
        Debug.Log("------------");
        Debug.Log(source_ID);
        if(itemFromPlayer == 0)
        {
            player.pickupItem(source_ID);
        }
        else if (itemFromPlayer == source_ID)
        {
            Debug.Log("Item put back the soure item.");
            player.putbackItem(itemFromPlayer);
            if(itemFromPlayer == 6)
            {
                
            }
        }
        else
        {
            Debug.Log("Item can't put back the soure item.");
        }
    }
}
