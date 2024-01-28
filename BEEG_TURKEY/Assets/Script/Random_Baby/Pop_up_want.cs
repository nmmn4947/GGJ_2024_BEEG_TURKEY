using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop_up_want : MonoBehaviour
{
    Random_kid_want rkw;
    public GameObject shaker;
    public GameObject doll;
    public GameObject car;
    public GameObject milk;
    public GameObject pencil;
    public GameObject toilet;
    public GameObject horsey;
    public GameObject bed;

    private void Start()
    {
        rkw = GetComponentInParent<Random_kid_want>();
    }

    void Update()
    {
        switch(rkw.getWant())
        {
            case Random_kid_want.KidWant.nothing:
                shaker.SetActive(false);
                doll.SetActive(false);
                car.SetActive(false);
                milk.SetActive(false);
                pencil.SetActive(false);
                toilet.SetActive(false);
                horsey.SetActive(false);
                bed.SetActive(false);
                break;

            case Random_kid_want.KidWant.shaker:
                shaker.SetActive(true);
                break;

            case Random_kid_want.KidWant.doll:
                doll.SetActive(true);
                break;

            case Random_kid_want.KidWant.car:
                car.SetActive(true);
                break;
            case Random_kid_want.KidWant.milk:
                milk.SetActive(true);
                break;
            case Random_kid_want.KidWant.pencil:
                pencil.SetActive(true);
                break;

            case Random_kid_want.KidWant.toilet:
                toilet.SetActive(true);
                break;

            case Random_kid_want.KidWant.horsey:
                horsey.SetActive(true);
                break;

            case Random_kid_want.KidWant.bed:
                bed.SetActive(true);
                break;
        }
    }
}
