using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{
    public TypeActionCollectable typeActionCollectable;
    public int valueToRestOrAdd;
    public GameObject particleDestroy = null;
    public AudioClip onclickCollisionAudio = null;
    public void setMyInfo(TypeActionCollectable typeActionCollectable, int valueToRestOrAdd, GameObject particleDestroy,AudioClip onclickCollisionAudio)
    {
        this.typeActionCollectable = typeActionCollectable;
        this.valueToRestOrAdd = valueToRestOrAdd;
        this.particleDestroy = particleDestroy;
        this.onclickCollisionAudio = onclickCollisionAudio;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if (typeActionCollectable == TypeActionCollectable.addPoint)
                GameManager.instanceGameManager.addPoints(valueToRestOrAdd);
            else if (typeActionCollectable == TypeActionCollectable.restPoint)
                GameManager.instanceGameManager.restPoints(valueToRestOrAdd);
            SoundManager.instanceSoundManager.onCollisionApple(onclickCollisionAudio);
            Instantiate(particleDestroy,this.transform.position,Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
