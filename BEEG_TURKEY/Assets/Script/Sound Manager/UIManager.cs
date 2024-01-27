using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider backgroundMusicSlider;
    public Slider soundEffectsSlider;
    public float defaultBackgroundMusicVolume = 1.0f;
    public float defaultSoundEffectsVolume = 1.0f;

    void Start()
    {
        if (backgroundMusicSlider != null)
        {
            backgroundMusicSlider.value = PlayerPrefs.GetFloat("BackgroundMusicVolume", defaultBackgroundMusicVolume); // Load or set default background music volume from PlayerPrefs
            backgroundMusicSlider.onValueChanged.AddListener(OnBackgroundMusicVolumeChanged); // Subscribe to background music volume slider change event
        }

        if (soundEffectsSlider != null)
        {
            soundEffectsSlider.value = PlayerPrefs.GetFloat("SoundEffectsVolume", defaultSoundEffectsVolume); // Load or set default sound effects volume from PlayerPrefs
            soundEffectsSlider.onValueChanged.AddListener(OnSoundEffectsVolumeChanged); // Subscribe to sound effects volume slider change event
        }

        Debug.Log("Default Background Music Volume: " + defaultBackgroundMusicVolume);
        Debug.Log("Default Sound Effects Volume: " + defaultSoundEffectsVolume);

    }

    // Update background music volume setting when the slider value changes
    void OnBackgroundMusicVolumeChanged(float value)
    {
        AudioManager.instance.SetBackgroundMusicVolume(value);
        PlayerPrefs.SetFloat("BackgroundMusicVolume", value); // Save background music volume setting to PlayerPrefs
    }

    // Update sound effects volume setting when the slider value changes
    void OnSoundEffectsVolumeChanged(float value)
    {
        AudioManager.instance.SetSoundEffectsVolume(value);
        PlayerPrefs.SetFloat("SoundEffectsVolume", value); // Save sound effects volume setting to PlayerPrefs
    }
}
