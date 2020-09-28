using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad : MonoBehaviour
{
   // public ParticleSystem deathParticles;
    public ParticleSystem effect;

    void OnCollisionEnter(UnityEngine.Collision col)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (col.gameObject.name == "Player2")
        {
            //Destroy();
            effect.Play();

        }
    }
   // public void Destroy()
   // {
   //     Instantiate(deathParticles, transform.position, Quaternion.identity);
   //    Destroy(gameObject);

   // }
}
