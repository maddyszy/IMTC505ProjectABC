using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    /**
    public Slider volumeSlider; 


    void Start()
    {

        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }
    **/

    public void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}
