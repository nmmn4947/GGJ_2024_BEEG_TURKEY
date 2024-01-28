using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanage : MonoBehaviour
{
    public void ReloadScene()
    {
        // Get the index of the current scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene by loading it again
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void NextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void BackScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex - 1 < 0)
        {

        }else
        {
            SceneManager.LoadScene(currentSceneIndex - 1);
        }
    }

    public void Resume()
    {

    }
}
