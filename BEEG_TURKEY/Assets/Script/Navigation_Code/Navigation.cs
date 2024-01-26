using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float range;
    [SerializeField] float minX;
    [SerializeField] float minY;
    [SerializeField] float maxX;
    [SerializeField] float maxY;

    Vector2 wayPoint;

    [SerializeField] private float pause_game;
    private float pause_keep;

    public enum KidState
    {
        Idle,
        Walking
    }

    KidState _state;

    void Start()
    {
        SetNewDestination();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            SetNewDestination();
        }
        _state = KidState.Walking;

        _state = KidState.Idle;

        Debug.DrawLine(new Vector2(maxY, maxX), new Vector2(minY, minX), Color.red);
    }

    void SetNewDestination()
    {
        wayPoint = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        SetNewDestination();
    }

    public KidState getState()
    {
        return _state;
    }
}
