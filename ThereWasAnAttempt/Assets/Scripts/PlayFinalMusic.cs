using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFinalMusic : MonoBehaviour
{
    [SerializeField] private AudioSource finalAudio;
    [SerializeField] private AudioSource mainAudio;

    public void PlayDangerMusic()
    {
        mainAudio.Stop();
        finalAudio.Play();
    }

    public void PlayMainMusic()
    {
        finalAudio.Stop();
        mainAudio.Play();
    }
}
