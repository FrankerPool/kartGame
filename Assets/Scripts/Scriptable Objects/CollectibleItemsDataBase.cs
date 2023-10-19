using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TypeActionCollectable
{
    addPoint,restPoint
}
[CreateAssetMenu(fileName = "CollectablesDataBase", menuName = "Database/Collectables")]
public class CollectibleItemsDataBase : ScriptableObject
{
    public Collectable[] CollectablesDataBase;
}
[System.Serializable]
public class Collectable
{
    public AudioClip onclickCollisionAudio;
    public GameObject collectablePrefab;
    public GameObject particlesOnDestroy;
    public TypeActionCollectable typeActionCollectable;
    public int valueToRestOrAdd;
}