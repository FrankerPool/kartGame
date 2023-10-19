using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource onclickBTN;
    public AudioSource onCollisionAppleSound;
    static public SoundManager instanceSoundManager;
    private void Awake()
    {
        instanceSoundManager = this;
    }
    public void onclickBTNSound()
    {
        onclickBTN.Play();
    }
    public void onCollisionApple(AudioClip sound)
    {
        onCollisionAppleSound.clip = sound;
        onCollisionAppleSound.Play();
    }
}
