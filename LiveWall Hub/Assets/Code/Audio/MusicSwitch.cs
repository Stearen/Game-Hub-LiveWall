using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitch : MonoBehaviour
{
    public AudioSource StartMusic;
    public AudioSource StopMusic;

    public void SwitchAudio()
    {
        StartMusic.Play();
        StopMusic.Stop();
    }


}
