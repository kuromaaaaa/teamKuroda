using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RainSound : MonoBehaviour
{
    AudioLowPassFilter alpf;
    [SerializeField] AudioSource ausWind, ausRain;
    public bool isUnderShelter = false;
    private void Start()
    {
        alpf = GetComponent<AudioLowPassFilter>();
    }

    private void Update()
    {
        if (isUnderShelter == true)
        {
            alpf.cutoffFrequency = 2000;
            ausRain.volume = 0.5f;
            ausWind.volume = 0f;
            ausWind.pitch = 0.5f;
        }
        else
        {
            alpf.cutoffFrequency = 5000;
            ausRain.volume = 1f;
            ausWind.volume = 1f;
            ausWind.pitch = 1f;
        }
    }
}
