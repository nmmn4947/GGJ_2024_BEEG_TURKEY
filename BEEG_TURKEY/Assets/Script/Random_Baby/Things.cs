using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Things : MonoBehaviour
{
    public bool WANT = false;
    [SerializeField] private float happyTime;
    public float sadTime;
    public float sadTimeKeep;
    private float hapTimeKeep;
    public bool yes = false;
    bool once = false;

    GameManager gameManager;
    KidWant_Operate kwo;
    Animator animator;
    Baby_Sounds sound;

    
    private void Start()
    {
        kwo = GetComponentInParent<KidWant_Operate>();
        gameManager = FindAnyObjectByType<GameManager>();
        sound = GetComponentInParent<Baby_Sounds>();
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
    int rand;
    protected void CountDown()
    {
        
        if (yes)
        {
            Debug.Log("Yessing");
            kwo.anim.SetBool("Crying", false);
            rand = Random.Range(1, 3);
            if(once == false)
            {
                if(rand == 1)
                {
                    sound.PlayLaugh();
                }
                else if (rand == 2)
                {
                    sound.PlayLaugh2();
                    Debug.Log("2");
                }
                else
                {
                    sound.PlayHappy();
                    Debug.Log("Happy");
                }
                
                once = true;
            }
            
            hapTimeKeep -= Time.deltaTime;
            if (hapTimeKeep <= 0)
            {
                
                kwo.Done = true;
                WANT = false;
                yes = false;
                hapTimeKeep = happyTime;
                once = false;
            }
        }
        else
        {
            sadTimeKeep -= Time.deltaTime;
            if (sadTimeKeep <= 0)
            {
                WANT = false;
                kwo.anim.Play("CRYSOHARD");
                sadTimeKeep = sadTime;
                gameManager.maxChaosMeter -= 1;
            }
        }
    }
}
