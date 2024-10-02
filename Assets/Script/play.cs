using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    // Reference to the AudioSource component
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Play the audio when the game starts
        if (audioSource != null)
        {
            audioSource.Play();
            Debug.Log("Audio is playing!");
        }
        else
        {
            Debug.LogWarning("AudioSource component not found on this GameObject.");
        }
    }
}