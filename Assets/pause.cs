using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Ensure the audio is playing at the start (optional)
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    // Method to pause the audio
    public void PauseAudio()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Pause();
            Debug.Log("Audio paused.");
        }
    }

    // Method to resume the audio
    public void ResumeAudio()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.UnPause();
            Debug.Log("Audio resumed.");
        }
    }

    // Optional: Method to stop the audio completely
    public void StopAudio()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
            Debug.Log("Audio stopped.");
        }
    }
}