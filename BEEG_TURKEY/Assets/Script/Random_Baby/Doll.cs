using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doll : MonoBehaviour
{
    public bool WANT = false;
    [SerializeField] private float happyTime;
    [SerializeField] private float sadTime;
    private float sadTimeKeep;
    private float hapTimeKeep;

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

            //if baby got da Doll
            hapTimeKeep -= Time.deltaTime;
            if (hapTimeKeep <= 0)
            {
                kwo.Done = true;
                WANT = false;
                hapTimeKeep = happyTime;
            }
            //else baby don't get da Doll
            sadTimeKeep -= Time.deltaTime;
            if (sadTimeKeep <= 0)
            {
                kwo.Done = true;
                WANT = false;
                sadTimeKeep = sadTime;
                Debug.Log("-Heart");
            }
        }
    }
}
