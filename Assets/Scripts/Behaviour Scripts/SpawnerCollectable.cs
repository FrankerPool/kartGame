using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCollectable : MonoBehaviour
{
    void Start()
    {
        spawnOtherCollectable();
    }
    public void spawnOtherCollectable()
    {
        AppleManager.appleManagerInstance.spawnRandomCollectable(this.transform);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            StartCoroutine(spawnCollectableCoroutine());
        }
    }
    public IEnumerator spawnCollectableCoroutine()
    {
        yield return new WaitForSeconds(2);
        spawnOtherCollectable();
    }
}
