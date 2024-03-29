using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text text1;
    [SerializeField] TMP_Text text2;
    [SerializeField] TMP_Text text3;
    [SerializeField] float secondPerGameTime;
    public int maxChaosMeter;
    private float gameTime;
    private bool isPause;
    [SerializeField] private int[] digitalClockTime;
    [SerializeField] private Image[] babyCrying;
    [SerializeField] private Sprite babyCryingTick;
    // Start is called before the first frame update

    public GameObject objectToToggle;

    void Awake()
    {
        digitalClockTime[1] = 2;
        digitalClockTime[2] = 0;
        digitalClockTime[3] = 0;
        ClockDisplay();
        isPause = false;
        Time.timeScale = 1;
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
        if(digitalClockTime[1] >= 6 && !isPause)
        {
            Debug.Log("Game end");
            Pause();
        }
        Debug.Log(maxChaosMeter);
        if (maxChaosMeter <= 0 && !isPause)
        {
            objectToToggle.SetActive(true);
            Pause();
        }

        UpdateBabyCryingUI();



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
            digitalClockTime[3] = 0;
        }
        else
        {
            digitalClockTime[3] += 1;
        }
        ClockDisplay();
    }

    void UpdateBabyCryingUI()
    {
        if(maxChaosMeter == 2)
        {
            babyCrying[2].sprite = babyCryingTick;
        }
        else if(maxChaosMeter == 1)
        {
            babyCrying[1].sprite = babyCryingTick;
        }
        else if (maxChaosMeter == 0)
        {
            babyCrying[0].sprite = babyCryingTick;
        }
    }

    void ClockDisplay()
    {
        text1.text = digitalClockTime[1].ToString();
        text2.text = digitalClockTime[2].ToString();
        text3.text = digitalClockTime[3].ToString();
    }

    void Pause()
    {
        if(!isPause)
        {
            Time.timeScale = 0;
            isPause = true;
        }
        else
        {
            Time.timeScale = 1;
            isPause = false;
        }
    }
}
