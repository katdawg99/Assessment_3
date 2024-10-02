using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_pause : MonoBehaviour
{
    // Reference to the AudioSource component
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        
        // Optionally start playing the audio on start
        // audioSource.Play();
    }

    void Update()
    {
        // Check for user input to toggle play/pause
        if (Input.GetKeyDown(KeyCode.Space)) // Change this key as needed
        {
            ToggleAudio();
        }
    }

    void OnMouseDown()
    {
        // Toggle play/pause on mouse click
        ToggleAudio();
    }

    private void ToggleAudio()
    {
        if (audioSource.isPlaying)
        {
            PauseAudio();
        }
        else
        {
            PlayAudio();
        }
    }

    public void PlayAudio()
    {
        audioSource.Play();
        Debug.Log("Audio Playing");
    }

    public void PauseAudio()
    {
        audioSource.Pause();
        Debug.Log("Audio Paused");
    }
}