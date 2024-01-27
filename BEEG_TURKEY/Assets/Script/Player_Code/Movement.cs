using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] private AudioClip footstepSFX;
    [SerializeField] private float speed;
    [SerializeField] private Camera _cam;
    [SerializeField] private GameObject AREA;
    private Rigidbody2D rigidbody;
    private AudioSource footStepAudioSource;
    public Animator animator;
    InteractWithObject IWO;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        footStepAudioSource = GetComponentInChildren<AudioSource>();
        IWO = GetComponent<InteractWithObject>();
    }

    void Update()
    {
        Vector2 playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rigidbody.velocity = playerInput.normalized * speed;
        if(rigidbody.velocity.magnitude > 0.2f)
        {
            footStepAudioSource.enabled = true;
        }
        else
        {
            footStepAudioSource.enabled = false;
        }
        animator.SetFloat("Forward", Input.GetAxisRaw("Vertical"));
        animator.SetFloat("Turn", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("Velocity", rigidbody.velocity.magnitude);

        if (IWO._itemID == 0)
        {
            animator.SetBool("item1", false);
            animator.SetBool("item2", false);
            animator.SetBool("item3", false);
            animator.SetBool("item4", false);
            animator.SetBool("item5", false);
        }
        else if (IWO._itemID == 1)
        {
            animator.SetBool("item1", true);
        }
        else if (IWO._itemID == 2)
        {
            animator.SetBool("item2", true);
        }
        else if (IWO._itemID == 3)
        {
            animator.SetBool("item3", true);
        }
        else if (IWO._itemID == 4)
        {
            animator.SetBool("item4", true);
        }
        else if (IWO._itemID == 5)
        {
            animator.SetBool("item5", true);
        }

    }
}
