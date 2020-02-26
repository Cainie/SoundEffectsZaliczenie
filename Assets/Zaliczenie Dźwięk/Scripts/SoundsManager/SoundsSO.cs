using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(menuName = "Sounds/SoundSO")]
public class SoundsSO : ScriptableObject
{
    public List<AudioClip> music;
    public List<AudioClip> playerMoveSounds;
    public List<AudioClip> playerEatSounds;
    public List<AudioClip> playerDrinkSounds;
    public List<AudioClip> playerChopSounds;
    public List<AudioClip> monsterAttackSounds;
    public AudioClip roundCompleted;
    public AudioClip gameOverSound;
    public AudioClip onButtonHoverSound;

    public float snapshotTransitionTime;
    public AudioMixerSnapshot gamePlayingSnapshot;
    public AudioMixerSnapshot gamePausedSnapshot;


}
