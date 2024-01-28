using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadSceneButton : MonoBehaviour
{
    void Start()
    {
        // Find the Button component attached to this GameObject
        Button button = GetComponent<Button>();

        // Add a listener for the button click event
        button.onClick.AddListener(ReloadScene);
    }

    // Method to reload the current scene
    void ReloadScene()
    {
        // Get the index of the current scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        GameManager gm = FindAnyObjectByType<GameManager>();
        gm.Restart();
        // Reload the current scene by loading it again
        SceneManager.LoadScene(currentSceneIndex);
        
        
    }
}
