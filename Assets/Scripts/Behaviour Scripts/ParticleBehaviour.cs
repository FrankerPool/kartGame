using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBehaviour : MonoBehaviour
{
    //
    public float timeActiveParticles;
    void Start()
    {
    }
    public IEnumerator destroyParticle()
    {
        yield return new WaitForSeconds(timeActiveParticles);
        this.gameObject.SetActive(true);
    }
}
