using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Slide_OverAllVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider mySlider;

    public void SetVolume()
    {
        float volume = mySlider.value;
        //myMixer.SetFloat("");
    }
}
