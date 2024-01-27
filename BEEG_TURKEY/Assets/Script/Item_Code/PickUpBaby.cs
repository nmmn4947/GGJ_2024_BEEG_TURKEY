using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBaby : MonoBehaviour
{
    public bool isPickedUp;
    InteractWithObject playerPos;
    Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        
        playerPos = FindAnyObjectByType<InteractWithObject>();
        collider = GetComponent<Collider2D>();
        isPickedUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPickedUp)
        {
            transform.position = playerPos.transform.position;
            collider.enabled = false;
            playerPos.holdingBaby = PickUpThisBaby();
        }
        else
        {
            collider.enabled = true;
        }
    }

    public PickUpBaby PickUpThisBaby()
    {
        return this;
    }
}
