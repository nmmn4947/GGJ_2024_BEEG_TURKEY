using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : Interactable
{
    [SerializeField] private int station_ID;
    [SerializeField] private InteractWithObject player;
    private Baby baby;
    // Start is called before the first frame update
    void Awake()
    {
        player = FindAnyObjectByType<InteractWithObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        int itemFromPlayer = player._itemID;
        Debug.Log(itemFromPlayer);
        Debug.Log("------------");
        Debug.Log(station_ID);
        baby = player.holdingBaby.GetComponent<Baby>();
        if (itemFromPlayer == 6 && station_ID == baby.getType())
        {
            Debug.Log("Type matched");
            player.holdingBaby.isPickedUp = false;
        }
    }
}
