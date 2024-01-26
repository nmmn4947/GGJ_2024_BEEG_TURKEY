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
    [SerializeField] private float walk_time;
    [SerializeField] private float stop_time;
    private float stop_keep;
    private float stop_keep2;

    public enum KidState
    {
        Idle,
        Walking
    }

    KidState _state;

    void Start()
    {
        SetNewDestination();
        stop_keep = walk_time;
        stop_keep2 = stop_time;
    }

    void Update()
    {
        Debug.Log("one " + stop_keep);
        Debug.Log("two " + stop_keep2);
        if (stop_keep <= 0)
        {
            _state = KidState.Idle;
            stop_keep2 -= Time.deltaTime;
            if (stop_keep2 <= 0)
            {
                stop_keep = walk_time;
            }
        }
        else
        {
            stop_keep -= Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, wayPoint) < range)
            {
                SetNewDestination();
            }
            _state = KidState.Walking;
            stop_keep2 = stop_time;
        }

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
