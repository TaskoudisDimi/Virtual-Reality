using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("UnitySetup")]
    public ParticleSystem deathParticles;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit");
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}