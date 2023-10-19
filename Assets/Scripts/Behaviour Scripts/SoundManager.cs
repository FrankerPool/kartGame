using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource onclickBTN;
    public AudioSource onCollisionAppleSound;
    public AudioSource engineCarSound;
    static public SoundManager instanceSoundManager;
    private void Awake()
    {
        instanceSoundManager = this;
    }
    //use when click a btn
    public void onclickBTNSound()
    {
        onclickBTN.Play();
    }
    //use when a apple is destroy
    public void onCollisionApple(AudioClip sound)
    {
        onCollisionAppleSound.clip = sound;
        onCollisionAppleSound.Play();
    }
    //use when the game is finish
    public void stopCarEngineSound()
    {
        engineCarSound.Stop();
    }
}
