using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Happy_Bar : MonoBehaviour
{
    public GameObject wants;
    Shaker shaker;
    Doll doll;
    Random_kid_want rkw;

    float sad;
    float initialScaleX;

    void Start()
    {
        rkw = Random_kid_want.;

        shaker = wants.GetComponent<Shaker>();
        doll = wants.GetComponent<Doll>();
        initialScaleX = transform.localScale.x;
    }

    void Update()
    {
        if ()
        {

        }

        sad = Mathf.Clamp01((shaker.sadTime - shaker.sadTimeKeep) / shaker.sadTime);

        // Calculate the new scale value for X-axis (width)
        float newScaleX = initialScaleX * sad;

        // Calculate the difference in scale on X-axis
        float deltaX = transform.localScale.x - newScaleX;

        // Move the bar to the left (negative direction) based on the difference
        transform.position += new Vector3(deltaX / 2, 0, 0);

        // Set the new scale, maintaining the original Y-axis scale
        transform.localScale = new Vector2(newScaleX, transform.localScale.y);
    }
}
