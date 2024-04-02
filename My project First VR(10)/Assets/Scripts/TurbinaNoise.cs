using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurbinaNoise : MonoBehaviour
{
    [SerializeField] private float volumeFactor;
    [SerializeField] private float pitchFactor;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        RotatingSpeedSlider.st.slider.onValueChanged.AddListener((val) =>
        {
            audioSource.volume = volumeFactor * val;
            audioSource.pitch = 1 + pitchFactor * val;
        });
    }
}
