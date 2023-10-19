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
    //set the info of this script whit the new info
    public void setMyInfo(TypeActionCollectable typeActionCollectable, int valueToRestOrAdd, GameObject particleDestroy,AudioClip onclickCollisionAudio)
    {
        this.typeActionCollectable = typeActionCollectable;
        this.valueToRestOrAdd = valueToRestOrAdd;
        this.particleDestroy = particleDestroy;
        this.onclickCollisionAudio = onclickCollisionAudio;
    }
    //check the collicion and compare type of collectable
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if (typeActionCollectable == TypeActionCollectable.addPoint)
                GameManager.instanceGameManager.addPoints(valueToRestOrAdd);
            else if (typeActionCollectable == TypeActionCollectable.restPoint)
                GameManager.instanceGameManager.restPoints(valueToRestOrAdd);
            //play the sound of apple on collision
            SoundManager.instanceSoundManager.onCollisionApple(onclickCollisionAudio);
            //instanciate particles of collision
            Instantiate(particleDestroy,this.transform.position,Quaternion.identity);
            //destroy this apple
            Destroy(this.gameObject);
        }
    }
}
