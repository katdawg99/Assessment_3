using UnityEngine;
using UnityEngine.UI; // Ensure this is included for UI components
using System.Collections; // Required for IEnumerator

public class ButtonAudioController : MonoBehaviour
{
    public AudioSource audioSource; // Reference to your AudioSource
    public Button button; // Reference to your UI Button
    public Sprite normalSprite; // Sprite for the normal state
    public Sprite transitionSprite; // Sprite for the transition effect

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
        Image buttonImage = button.GetComponent<Image>();
        Sprite originalSprite = buttonImage.sprite;
        float duration = 0.5f; // Duration of the transition
        float elapsedTime = 0f;

        // Change the button sprite to the transition sprite
        buttonImage.sprite = transitionSprite;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            yield return null; // Wait for the next frame
        }

        // Reset button sprite after transition
        buttonImage.sprite = originalSprite;

        // Resume audio playback after transition
        audioSource.UnPause();
    }
}