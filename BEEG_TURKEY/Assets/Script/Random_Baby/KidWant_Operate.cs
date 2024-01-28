using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class KidWant_Operate : MonoBehaviour
{
    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;
    Random_kid_want rkw;
    public Animator anim;
    Baby_Sounds sound;
    Shaker shaker;
    Doll doll;
    Car car;

    private float time;

    public bool Done = false;
    private void Start()
    {
        rkw = GetComponent<Random_kid_want>();
        shaker = GetComponentInChildren<Shaker>();
        doll = GetComponentInChildren<Doll>();
        car = GetComponentInChildren<Car>();

        anim = GetComponentInChildren<Animator>();
        time = rkw.getRandTime(minTime, maxTime);
        sound = GetComponent<Baby_Sounds>();
        

    }
    bool once = false;
    private void Update()
    {
        if (rkw.getWant() == Random_kid_want.KidWant.nothing){
            if (time <= 0)
            {
                rkw.RandWant();
                anim.SetBool("Crying", true);
                anim.Play("Baby_StartCrying");
                if (once == false)
                {
                    sound.PlayCry();
                    once = true;
                }
                
                switch (rkw.getWant())
                {
                    case Random_kid_want.KidWant.shaker:
                        shaker.WANT = true;
                        
                        break;
                    case Random_kid_want.KidWant.doll:
                        doll.WANT = true;
                        
                        break;
                    case Random_kid_want.KidWant.car:
                        car.WANT = true;

                        break;
                    case Random_kid_want.KidWant.milk:
                        

                        break;
                    case Random_kid_want.KidWant.pencil:
                        

                        break;
                    case Random_kid_want.KidWant.toilet:
                        

                        break;
                    case Random_kid_want.KidWant.horsey:
                        

                        break;
                    case Random_kid_want.KidWant.bed:
                        

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
                rkw.setWant(Random_kid_want.KidWant.nothing);
                time = rkw.getRandTime(minTime, maxTime);
                Done = false;
                once = false;
            }
        }

    }
}