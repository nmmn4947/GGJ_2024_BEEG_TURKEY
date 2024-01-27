using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Navigation;

public class Random_kid_want : MonoBehaviour
{
    public enum KidWant
    {
        nothing,
        shaker, //กุ้งกิ้ง
        doll,
        car,
        toilet,
        horsey,
        bed
    }
    int rand;

    public KidWant _want;

    public void RandWant()
    {
        rand = Random.Range(1, 60);
        if (rand <= 10)
        {
            _want = KidWant.shaker;
        }
        else if(rand <= 20)
        {
            _want = KidWant.doll;
        }
        else if (rand <= 30)
        {
            _want = KidWant.car;
        }
        else if (rand <= 40)
        {
            _want = KidWant.toilet;
        }
        else if (rand <= 50)
        {
            _want = KidWant.horsey;
        }
        else
        {
            _want = KidWant.bed;
        }
    }

    public KidWant getWant() { return _want; }

    public float getRandTime(float min, float max)
    {
        return Random.Range(min, max);
    }

    public void setWant(KidWant state)
    {
        _want = state;
    }

}
