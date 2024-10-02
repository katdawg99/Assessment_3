using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    // Volume increment step
    public float volumeStep = 0.1f;

    // Minimum and maximum volume levels
    public float minVolume = 0.0f;
    public float maxVolume = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize volume to a default value if needed
        AudioListener.volume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // Increase volume when the "UpArrow" key is pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            IncreaseVolume();
        }

        // Decrease volume when the "DownArrow" key is pressed
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DecreaseVolume();
        }
    }

    void IncreaseVolume()
    {
        AudioListener.volume = Mathf.Clamp(AudioListener.volume + volumeStep, minVolume, maxVolume);
        Debug.Log("Volume increased to: " + AudioListener.volume);
    }

    void DecreaseVolume()
    {
        AudioListener.volume = Mathf.Clamp(AudioListener.volume - volumeStep, minVolume, maxVolume);
        Debug.Log("Volume decreased to: " + AudioListener.volume);
    }
}