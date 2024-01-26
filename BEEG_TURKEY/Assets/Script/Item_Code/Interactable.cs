using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected State itemState;
    public virtual void Interact()
    {
        //interact logic
    }

    protected State GetState()
    {
        return itemState;
    }

    public enum State
    {
        Normal,
        Interacted
    }
}
