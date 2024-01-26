using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Interactable : MonoBehaviour
{
    protected State itemState;
    protected AudioSource audioSource;
    protected AudioClip interactSFX;

    public virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
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
