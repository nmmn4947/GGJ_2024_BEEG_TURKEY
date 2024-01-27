using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToFirstSceneButton : MonoBehaviour
{
    void Start()
    {
        // Find the Button component attached to this GameObject
        Button button = GetComponent<Button>();

        // Add a listener for the button click event
        button.onClick.AddListener(ReturnToFirstScene);
    }

    // Method to return to the first scene in the build
    void ReturnToFirstScene()
    {
        // Load the first scene in the build
        SceneManager.LoadScene(0);
    }
}

