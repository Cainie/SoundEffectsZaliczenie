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
        mainAudioMixer.GetFloat(exposedVolumeParamName, out float volume);
        _slider.value = volume;
    }

    public void SetAudioVolume() {
        mainAudioMixer.SetFloat(exposedVolumeParamName, CaluculateDecybels(_slider.value));
    }
    
    private float CaluculateDecybels(float sliderValue){
        return Mathf.Log(sliderValue) * 20;
    }
}
