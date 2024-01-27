using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Things : MonoBehaviour
{
    public bool WANT = false;
    [SerializeField] private float happyTime;
    public float sadTime;
    public float sadTimeKeep;
    private float hapTimeKeep;
    public bool yes = false;


    KidWant_Operate kwo;
    private void Start()
    {
        kwo = GetComponentInParent<KidWant_Operate>();
        sadTimeKeep = sadTime;
        hapTimeKeep = happyTime;
    }
    void Update()
    {
        if (WANT)
        {

            CountDown();

        }
    }

    protected void CountDown()
    {
        if (yes)
        {
            hapTimeKeep -= Time.deltaTime;
            if (hapTimeKeep <= 0)
            {
                kwo.Done = true;
                WANT = false;
                yes = false;
                hapTimeKeep = happyTime;
            }
        }
        else
        {
            sadTimeKeep -= Time.deltaTime;
            if (sadTimeKeep <= 0)
            {
                kwo.Done = true;
                WANT = false;
                sadTimeKeep = sadTime;
            }
        }
    }
}
