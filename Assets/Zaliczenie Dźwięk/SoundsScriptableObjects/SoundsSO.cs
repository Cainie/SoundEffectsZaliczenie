using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(menuName = "Sounds/SoundSO")]
public class SoundsSO : ScriptableObject
{
    public List<AudioClip> music;
    public AudioClip roundCompleted;
    public AudioClip moveSound1;
    public AudioClip moveSound2;
    public AudioClip eatSound1;
    public AudioClip eatSound2;
    public AudioClip drinkSound1;
    public AudioClip drinkSound2;
    public AudioClip gameOverSound;
    public AudioClip attackSound1;
    public AudioClip attackSound2;
    public AudioClip chopSound1;
    public AudioClip chopSound2;
    public AudioClip onButtonHoverSound;

    public float snapshotTransitionTime;
    public AudioMixerSnapshot gamePlayingSnapshot;
    public AudioMixerSnapshot gamePausedSnapshot;


}
