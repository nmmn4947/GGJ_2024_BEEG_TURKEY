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
    private float _camSizeX;
    private float _camSizeY;
    private Animator animator;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        footStepAudioSource = GetComponentInChildren<AudioSource>();
        Debug.Log(_cam.orthographicSize);
        _camSizeY = _cam.orthographicSize - 0.5f;
        _camSizeX = _cam.orthographicSize + 3.38f;
    }

    private void checkArea(Vector3 playerPosition)
    {
        bool isOverlapping = this.AREA.transform.GetChild(0).GetComponent<BoxCollider2D>().OverlapPoint(playerPosition);
        Debug.Log(isOverlapping);
    }

    void Update()
    {
        // ตรวจสอบการกดปุ่ม W A S D
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


        /*float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float xSpeed = horizontalInput * player.playerSpeedX * Time.deltaTime;
        float ySpeed = verticalInput * player.playerSpeedY * Time.deltaTime;*/

        // เคลื่อนที่ตามแกน X, Y และ Z
        /*Vector3 movement = new Vector3(xSpeed, ySpeed, 0.0f);*/
        //player.transform.Translate(movement);

        /*Vector3 position = player.transform.position;
        if (position.x < -(_camSizeX))
        {
            position.x = -(_camSizeX);
        }
        else if (position.x > _camSizeX)
        {
            position.x = _camSizeX;
        }

        if (position.y < -(_camSizeY))
        {
            position.y = -(_camSizeY);
        }
        else if (position.y > _camSizeY)
        {
            position.y = _camSizeY;
        }
        player.transform.position = position;

        checkArea(player.transform.position);*/
    }
}
