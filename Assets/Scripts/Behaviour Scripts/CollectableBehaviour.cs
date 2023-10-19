using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{
    public TypeActionCollectable typeActionCollectable;
    public int valueToRestOrAdd;
    public GameObject particleDestroy = null;
    public void setMyInfo(TypeActionCollectable typeActionCollectable, int valueToRestOrAdd, GameObject particleDestroy)
    {
        this.typeActionCollectable = typeActionCollectable;
        this.valueToRestOrAdd = valueToRestOrAdd;
        this.particleDestroy = particleDestroy;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if (typeActionCollectable == TypeActionCollectable.addPoint)
                GameManager.instanceGameManager.addPoints(valueToRestOrAdd);
            else if (typeActionCollectable == TypeActionCollectable.restPoint)
                GameManager.instanceGameManager.restPoints(valueToRestOrAdd);
            Instantiate(particleDestroy,this.transform.position,Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
