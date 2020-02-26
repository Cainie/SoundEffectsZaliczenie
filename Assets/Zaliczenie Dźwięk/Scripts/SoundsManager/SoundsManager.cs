using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SoundsManager : MonoBehaviour
{
    public static SoundsManager instance;
    [SerializeField] private SoundsSO soundsSO;
    [SerializeField] private AudioSource sfxAudioSource;
    [SerializeField] private AudioSource musicAudioSource;
    [SerializeField] private AudioSource UIAudioSource;
    

    private void Start(){
        StartCoroutine(PlayMusic());
    }

    private void Awake () {
        if (instance == null){
            instance = this;
        }else if (instance != this){
            Destroy (gameObject);
        }
        DontDestroyOnLoad (gameObject);
    }

    public void PlayPlayerMoveSound(){
        var randomClip = GetRandomAudioClipFromList(soundsSO.playerMoveSounds);
        sfxAudioSource.PlayOneShot(randomClip);
    }
    
    public void PlayPlayerEatSound(){
        var randomClip = GetRandomAudioClipFromList(soundsSO.playerEatSounds);
        sfxAudioSource.PlayOneShot(randomClip);
    }

    public void PlayPlayerDrinkSound(){
        var randomClip = GetRandomAudioClipFromList(soundsSO.playerDrinkSounds);
        sfxAudioSource.PlayOneShot(randomClip);
    }

    public void PlayPlayerChopSound(){
        var randomClip = GetRandomAudioClipFromList(soundsSO.playerChopSounds);
        sfxAudioSource.PlayOneShot(randomClip);
    }

    public void PlayMonsterAttackSound(){
        var randomClip = GetRandomAudioClipFromList(soundsSO.monsterAttackSounds);
        sfxAudioSource.PlayOneShot(randomClip);
    }

    public void PlayRoundCompletedSound(){
        sfxAudioSource.PlayOneShot(soundsSO.roundCompleted);
    }

    public void PlayGameOverSound(){
        sfxAudioSource.PlayOneShot(soundsSO.gameOverSound);
        StopAllCoroutines();
    }

    public void PlayOnButtonHoverSound(){
        UIAudioSource.PlayOneShot(soundsSO.onButtonHoverSound);
    }

    public void GamePaused() {
        soundsSO.gamePausedSnapshot.TransitionTo(soundsSO.snapshotTransitionTime);
    }

    public void GamePlaying() {
        soundsSO.gamePlayingSnapshot.TransitionTo(soundsSO.snapshotTransitionTime);
    }

    private IEnumerator PlayMusic(){
        for (;;){
            var randomMusicClip = GetRandomAudioClipFromList(soundsSO.music);
            var randomMusicClipLength = randomMusicClip.length;
            musicAudioSource.clip = randomMusicClip;
            musicAudioSource.Play();
            yield return new WaitForSeconds(randomMusicClipLength);
        }
    }

    private AudioClip GetRandomAudioClipFromList(List<AudioClip> audioClips){
        var randomClipIndex = Random.Range(0,audioClips.Count);
        return audioClips[randomClipIndex];
    }
    
    

}
