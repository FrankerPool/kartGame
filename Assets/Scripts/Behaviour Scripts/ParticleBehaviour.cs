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
    //destroy particle on collision whit particle
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            StartCoroutine(destroyParticle());
        }
    }
    //destroy particle coroutine
    public IEnumerator destroyParticle()
    {
        yield return new WaitForSeconds(timeActiveParticles);
        this.gameObject.SetActive(true);
    }
}
