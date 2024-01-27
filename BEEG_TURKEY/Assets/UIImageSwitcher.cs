using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class UIImageSwitcher : MonoBehaviour
{
    public Sprite[] imageSprites; // Array to hold references to the image sprites
    private int currentIndex = 0; // Current index of the displayed image

    private UnityEngine.UI.Image imageComponent; // Reference to the UI Image component

    void Start()
    {
        imageComponent = GetComponent<UnityEngine.UI.Image>(); // Get reference to the UI Image component
        ShowImage(currentIndex); // Show the starting image
    }

    void Update()
    {
        // Listen for mouse click on the image
        if (Input.GetMouseButtonDown(0))
        {
            // Check if the mouse click hits the image
            if (RectTransformUtility.RectangleContainsScreenPoint(imageComponent.rectTransform, Input.mousePosition))
            {
                // Switch to the next image
                currentIndex = (currentIndex + 1) % imageSprites.Length;
                ShowImage(currentIndex);
            }
        }
    }

    // Method to show the image at the given index
    void ShowImage(int index)
    {
        // Ensure index is within bounds
        if (index >= 0 && index < imageSprites.Length)
        {
            // Set the sprite of the UI Image component
            imageComponent.sprite = imageSprites[index];
        }
        
    }
}
