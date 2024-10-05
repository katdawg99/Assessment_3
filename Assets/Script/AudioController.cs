using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Ensure this is included for UI components

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource; // Reference to your AudioSource
    public Button playButton; // Reference to your Play Button
    public Button pauseButton; // Reference to your Pause Button

    private static AudioController instance; // Singleton instance

    void Awake()
    {
        // Implement singleton pattern to ensure only one instance exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Make this object persistent across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
    }

    void Start()
    {
        // Add listeners for button clicks
        playButton.onClick.AddListener(PlayAudio);
        pauseButton.onClick.AddListener(PauseAudio);
    }

    // Method to play the audio
    public void PlayAudio()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource is not assigned.");
        }
    }

    // Method to pause the audio
    public void PauseAudio()
    {
        if (audioSource != null)
        {
            audioSource.Pause();
        }
        else
        {
            Debug.LogWarning("AudioSource is not assigned.");
        }
    }
}