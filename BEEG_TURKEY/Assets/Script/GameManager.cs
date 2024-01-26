using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text text1;
    [SerializeField] TMP_Text text2;
    [SerializeField] TMP_Text text3;
    [SerializeField] float secondPerGameTime;
    [SerializeField] int maxChaosMeter;
    private float gameTime;
    [SerializeField]  private int[] digitalClockTime;
    // Start is called before the first frame update
    void Awake()
    {
        digitalClockTime[1] = 2;
        digitalClockTime[2] = 0;
        digitalClockTime[3] = 0;
        ClockDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
        if (gameTime >= secondPerGameTime)
        {
            GameTimeToClock();
            gameTime = 0;




















        }
    }

    void GameTimeToClock()
    {
        if(digitalClockTime[2] == 5 && digitalClockTime[3] == 9)
        {
            digitalClockTime[1] += 1;
            digitalClockTime[2] = 0; 
            digitalClockTime[3] = 0;
        }
        else if(digitalClockTime[3] == 9)
        {
            digitalClockTime[2] += 1;
        }
        else
        {
            digitalClockTime[3] += 1;
        }
        ClockDisplay();
    }

    void ClockDisplay()
    {
        text1.text = digitalClockTime[1].ToString();
        text2.text = digitalClockTime[2].ToString();
        text3.text = digitalClockTime[3].ToString();
    }
}