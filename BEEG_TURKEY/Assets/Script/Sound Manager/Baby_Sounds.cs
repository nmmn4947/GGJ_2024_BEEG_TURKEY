using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby_Sounds : MonoBehaviour
{
    public AudioSource source;
    public AudioClip walk;
    public AudioClip cry;
    public AudioClip laugh;
    public AudioClip happy;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayWalk()
    {
        source.PlayOneShot(walk);
    }

    public void PlayCry()
    {
        source.PlayOneShot(cry);
    }

    public void PlayLaugh()
    {
        source.PlayOneShot(laugh);
    }

    public void PlayHappy()
    {
        source.PlayOneShot(happy);
    }
}
