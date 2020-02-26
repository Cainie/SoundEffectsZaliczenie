using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixer mainAudioMixer;
    [SerializeField] private string exposedVolumeParamName;
    [SerializeField] private Slider _slider;
    
    private void Start() {
        _slider.value = 1;
    }

    public void SetAudioVolume() {
        mainAudioMixer.SetFloat(exposedVolumeParamName, CalculateDecibels(_slider.value));
    }
    
    private float CalculateDecibels(float sliderValue){
        return Mathf.Log(sliderValue) * 20;
    }
}
