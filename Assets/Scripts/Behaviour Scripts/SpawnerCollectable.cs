using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCollectable : MonoBehaviour
{
    //spawn random collectable on start script
    void Start()
    {
        spawnOtherCollectable();
    }
    //take a random collcetable of collection and instantiate in spawn poit
    public void spawnOtherCollectable()
    {
        AppleManager.appleManagerInstance.spawnRandomCollectable(this.transform);
    }
    //spawn other collctable on collision whit player
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            StartCoroutine(spawnCollectableCoroutine());
        }
    }
    //spawn collectable but wait for 2 seconds
    public IEnumerator spawnCollectableCoroutine()
    {
        yield return new WaitForSeconds(2);
        spawnOtherCollectable();
    }
}
