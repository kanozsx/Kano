using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioManager_1 Instance;
    private AudioManager_1() { }
    private void Awake()
    {
        Instance = this;
    }

    public AudioSource last;
    public AudioSource next;
    public AudioSource collect;
    public AudioSource win;
    public AudioSource walk;

    public void playNextBtnEffect()
    {
        next.Play();
    }
    public void playLatBtnEffect()
    {
        last.Play();
    }
    public void playCollectBtnEffect()
    {
        collect.Play();
    }
    public void playWinEffect()
    {
        win.Play();
    }
    public void playWalkEffect()
    {
        walk.Play();
    }
}
