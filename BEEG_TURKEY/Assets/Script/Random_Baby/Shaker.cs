using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    public bool WANT = false;
    [SerializeField] private float happyTime;
    public float sadTime;
    public float sadTimeKeep;
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

            if (Input.GetKey(KeyCode.E)) {
                hapTimeKeep -= Time.deltaTime;
                if (hapTimeKeep <= 0)
                {
                    kwo.Done = true;
                    WANT = false;
                    hapTimeKeep = happyTime;
                }
            }
            else if(Input.GetKey(KeyCode.Q))
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
}
