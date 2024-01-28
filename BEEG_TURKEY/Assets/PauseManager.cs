using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuCanvas; // Reference to the Pause Menu Canvas

    private bool isPaused = false; // Flag to track the pause state

    void Update()
    {
        // Check for ESC key press to toggle pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    // Method to toggle pause state and activate/deactivate Pause Menu
    public void TogglePause()
    {
        isPaused = !isPaused; // Toggle the pause state

        // If game is paused, activate Pause Menu and freeze time
        if (isPaused)
        {
            Time.timeScale = 0f; // Pause the game
            pauseMenuCanvas.SetActive(true); // Activate Pause Menu
        }
        // If game is unpaused, deactivate Pause Menu and resume time
        else
        {
            Time.timeScale = 1f; // Resume the game
            pauseMenuCanvas.SetActive(false); // Deactivate Pause Menu
        }
    }

    // Method to resume the game (used by Resume Button in Pause Menu)
    public void ResumeGame()
    {
        TogglePause(); // Toggle pause state to resume the game
    }
}

