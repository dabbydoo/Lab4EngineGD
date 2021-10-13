using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAudioPlayer : MonoBehaviour
{
    private AudioSource _audiosource;
    public AudioClip ac;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        ClickScore.clicked += PlayAudio;
        ClickHealth.clicked += PlayAudio;
    }

    private void OnDisable()
    {
        ClickScore.clicked -= PlayAudio;
        ClickHealth.clicked -= PlayAudio;
    }

    private void PlayAudio()
    {

        _audiosource.PlayOneShot(ac);
    }
}
