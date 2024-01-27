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
    private Animator animator;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        footStepAudioSource = GetComponentInChildren<AudioSource>();
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
    }
}
