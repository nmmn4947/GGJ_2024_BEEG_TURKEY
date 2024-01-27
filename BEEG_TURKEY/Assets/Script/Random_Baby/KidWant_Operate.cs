using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class KidWant_Operate : MonoBehaviour
{
    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;
    Random_kid_want rkw;

    Shaker shaker;
    Doll doll;

    private float time;

    public bool Done = false;
    private void Start()
    {
        rkw = GetComponent<Random_kid_want>();
        shaker = GetComponentInChildren<Shaker>();
        doll = GetComponentInChildren<Doll>();

        time = rkw.getRandTime(minTime, maxTime);
        
    }

    private void Update()
    {
        //Debug.Log(rkw.getWant());
        if (rkw.getWant() == Random_kid_want.KidWant.nothing){
            if (time <= 0)
            {
                rkw.RandWant();
                switch (rkw.getWant())
                {
                    case Random_kid_want.KidWant.shaker:
                        shaker.WANT = true;
                        break;
                    case Random_kid_want.KidWant.doll:
                        doll.WANT = true;
                        break;
                    case Random_kid_want.KidWant.car:
                        //require
                        break;
                    case Random_kid_want.KidWant.toilet:
                        //require
                        break;
                    case Random_kid_want.KidWant.horsey:
                        //require
                        break;
                    case Random_kid_want.KidWant.bed:
                        //require
                        break;
                    case Random_kid_want.KidWant.carry:
                        //require
                        break;
                }
            }
            else
            {
                time -= Time.deltaTime;
            }
        }
        else
        {
            if (Done)
            {
                Debug.Log("Done");
                rkw.setWant(Random_kid_want.KidWant.nothing);
                time = rkw.getRandTime(minTime, maxTime);
                Done = false;
            }
        }

    }
}