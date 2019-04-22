using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{

    public Slider slider;
    public AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = slider.value;
    }
}
