using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby_Sounds : MonoBehaviour
{
    public AudioSource source;
    public AudioClip laugh2;
    public AudioClip cry;
    public AudioClip laugh;
    public AudioClip happy;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayLaugh2()
    {
        source.PlayOneShot(laugh2);
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
