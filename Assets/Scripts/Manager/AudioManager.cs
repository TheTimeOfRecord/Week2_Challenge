using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : SingleTon<AudioManager>
{
    private BGMPlayer bgmPlayer;
    public AudioClip audioClip;

    protected override void Awake()
    {
        base.Awake();
        if(TryGetComponent<BGMPlayer>(out bgmPlayer))
        {
            
        }
        else
        {
            bgmPlayer = Instance.AddComponent<BGMPlayer>();
        }
    }


    public void PlayAudio()
    {
        Debug.Log("PlayAudio!");
        bgmPlayer.BGMStart(audioClip);
    }

    public void StopAudio()
    {
        Debug.Log("StopAudio!");
    }
}