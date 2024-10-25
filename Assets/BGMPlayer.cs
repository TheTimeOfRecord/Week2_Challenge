using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    public AudioSource bgmSource;
    public AudioClip bgmClip;

    private void Awake()
    {
        if(bgmSource == null)
        {
            bgmSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void BGMStart(AudioClip audioClip)
    {
        bgmSource.clip = audioClip;
        bgmSource.loop = true;

        bgmSource.Play();
    }

}
