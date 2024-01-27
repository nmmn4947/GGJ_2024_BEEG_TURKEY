using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance; // Singleton instance

    public AudioSource[] soundEffects; // Array of sound effect audio sources
    public AudioSource[] backgroundMusic; // Array of background music audio sources

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep AudioManager persistent across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
            return;
        }
    }

    // Play a sound effect
    public void PlaySoundEffect(int index)
    {
        if (index >= 0 && index < soundEffects.Length)
        {
            soundEffects[index].Play();
        }
    }

    // Play background music
    public void PlayBackgroundMusic(int index)
    {
        if (index >= 0 && index < backgroundMusic.Length)
        {
            backgroundMusic[index].Play();
        }
    }

    // Pause all background music
    public void PauseAllBackgroundMusic()
    {
        foreach (AudioSource music in backgroundMusic)
        {
            music.Pause();
        }
    }

    // Resume all background music
    public void ResumeAllBackgroundMusic()
    {
        foreach (AudioSource music in backgroundMusic)
        {
            music.UnPause();
        }
    }

    // Adjust the volume of background music
    public void SetBackgroundMusicVolume(float volume)
    {
        foreach (AudioSource music in backgroundMusic)
        {
            music.volume = volume;
        }
    }

    // Adjust the volume of sound effects
    public void SetSoundEffectsVolume(float volume)
    {
        foreach (AudioSource sound in soundEffects)
        {
            sound.volume = volume;
        }
    }
}


