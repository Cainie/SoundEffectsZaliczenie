﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    public static SoundsManager instance;
    [SerializeField] private SoundsSO soundsSO;
    [SerializeField] private AudioSource sfxAudioSource;
    [SerializeField] private AudioSource musicAudioSource;
    
    
    private void Awake () {
        if (instance == null){
            instance = this;
        }else if (instance != this){
            Destroy (gameObject);
        }
        DontDestroyOnLoad (gameObject);
    }
    
    

}
