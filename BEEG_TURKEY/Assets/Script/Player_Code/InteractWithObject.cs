using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour
{
    [SerializeField] private float interactRange;
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


    

}
