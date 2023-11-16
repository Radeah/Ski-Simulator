using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VRSceneController : MonoBehaviour
{
    // Reference to the UI button
    public Button playButton;

    private void Start()
    {
        // Add a listener to the button click event
        playButton.onClick.AddListener(PlayAndMoveToNextScene);
    }

    private void PlayAndMoveToNextScene()
    {
        // Add any play-related logic here

        // Load the next scene
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
