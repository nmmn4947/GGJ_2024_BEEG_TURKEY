using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : Interactable
{
    [SerializeField] private int station_ID;
    [SerializeField] private InteractWithObject player;
    [SerializeField] private Baby baby;
    public bool isBabyputback = false;
    // Start is called before the first frame update
    void Awake()
    {
        player = FindAnyObjectByType<InteractWithObject>();
        baby = FindAnyObjectByType<Baby>();
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
        if (itemFromPlayer == station_ID)
        {
            Debug.Log("Putback baby matched");
            baby.GetComponent<PickUpBaby>().isPickedUp = false;
            isBabyputback = true;
            if (isBabyputback)
            {
                Debug.Log("Station have baby");
                baby.DisableSrite();
            }
            else
            {
                Debug.Log("Station not have baby");
            }
            //player.holdingBaby.isPickedUp = false;
        }
    }
}
