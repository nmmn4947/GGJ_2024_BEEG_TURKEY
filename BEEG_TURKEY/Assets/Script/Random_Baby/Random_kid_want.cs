using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Navigation;

public class Random_kid_want : MonoBehaviour
{
    public enum KidWant
    {
        shaker, //กุ้งกิ้ง
        doll,
        car,
        toilet,
        horsey,
        bed,
        carry
    }
    int rand1;
    int rand2;

    KidWant _want;

    public void RandWant()
    {
        rand1 = Random.Range(1, 100);
        rand2 = Random.Range(1, 90);
        if (rand1 <= 40)
        {
            if(rand2 <= 30)
            {
                _want = KidWant.shaker;
            }else if (rand2 <= 60)
            {
                _want = KidWant.doll;
            }
            else
            {
                _want = KidWant.car;
            }
        }
        else if(rand1 <= 80)
        {
            if (rand2 <= 30)
            {
                _want = KidWant.toilet;
            }
            else if (rand2 <= 60)
            {
                _want = KidWant.horsey;
            }
            else
            {
                _want = KidWant.bed;
            }
        }
        else
        {
            _want = KidWant.carry;
        }
    }

    public KidWant getWant() { return _want; }
}
