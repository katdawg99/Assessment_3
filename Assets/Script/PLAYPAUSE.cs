using UnityEngine;
using UnityEngine.UI; // Ensure this is included for UI components
using System.Collections; // Required for IEnumerator

public class ButtonAudioController : MonoBehaviour
{
    public AudioSource audioSource; // Reference to your AudioSource
    public Button button; // Reference to your UI Button

    void Start()
    {
        // Add listener for button click
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        StartCoroutine(HandleButtonTransition());
    }

    private IEnumerator HandleButtonTransition()
    {
        // Pause the audio if it is currently playing
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }

        // Play the button transition effect (you can customize this)
        Color originalColor = button.GetComponent<Image>().color;
        Color targetColor = Color.grey; // Change to desired color during transition

        float duration = 0.5f; // Duration of the transition
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;

            // Lerp color for visual feedback
            button.GetComponent<Image>().color = Color.Lerp(originalColor, targetColor, t);
            yield return null; // Wait for the next frame
        }

        // Reset button color after transition
        button.GetComponent<Image>().color = originalColor;

        // Resume audio playback after transition
        audioSource.UnPause();
    }
}