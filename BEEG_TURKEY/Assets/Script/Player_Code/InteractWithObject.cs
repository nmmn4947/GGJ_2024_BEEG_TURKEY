using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour
{
    [SerializeField] private float interactRange;
    [SerializeField] public int _itemID;
    public PickUpBaby holdingBaby;
    const int BABY_ID = 6;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D interactRadius = Physics2D.OverlapCircle(transform.position, interactRange, LayerMask.GetMask("Interactable"));
        if (interactRadius != null)

        if (interactRadius.TryGetComponent<Interactable>(out Interactable item) && Input.GetKeyDown(KeyCode.E))
        {
            item.Interact();
        }
    }

    public void pickupItem(int item)
    {
        // 1 - 5 = item 
        // 6 = baby
        // 0 = nothing in hand
        Debug.Log("pickup: " + item);
        if(item == BABY_ID)
        {
            _itemID = BABY_ID;
        }
        else if(item > 0)
        {
            _itemID = item;
        }
        else
        {
            _itemID = 0;
        }
    }    

    public bool putbackItem(int item)
    {
        if (_itemID == item)
        {
            _itemID = 0;
            return true;
        }
        return false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, interactRange);
    }
}
