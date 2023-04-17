using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioManager1 Instance;
    private AudioManager1() { }
    public AudioSource music;

    private void Awake()
    {
        Instance = this;
    }

    public void playBtnMusic()
    {
        music.Play();
    }
}
