﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms.Impl;

public class CollectBalls : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        Score.theScore += 10;
        Destroy(gameObject);
        

    }

}
