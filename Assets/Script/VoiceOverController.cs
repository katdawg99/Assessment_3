using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Ensure this is included for UI components

public class VoiceOverController : MonoBehaviour
{
    public AudioSource audioSource; // Reference to your AudioSource
    public Button playButton; // Reference to your Play Button
    public Button pauseButton; // Reference to your Pause Button

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