using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleManager : MonoBehaviour
{
    public CollectibleItemsDataBase collectibleItemsDataBase;
    static public AppleManager appleManagerInstance;
    private void Awake()
    {
        appleManagerInstance = this;
    }

    public void spawnRandomCollectable(Transform position)
    {
        int randomObj = Random.Range(0,collectibleItemsDataBase.CollectablesDataBase.Length);
        GameObject apple = Instantiate(collectibleItemsDataBase.CollectablesDataBase[randomObj].collectablePrefab,position);
        apple.GetComponent<CollectableBehaviour>().setMyInfo(
                   collectibleItemsDataBase.CollectablesDataBase[randomObj].typeActionCollectable,
                   collectibleItemsDataBase.CollectablesDataBase[randomObj].valueToRestOrAdd,
                   collectibleItemsDataBase.CollectablesDataBase[randomObj].particlesOnDestroy
                   );
    }
}
