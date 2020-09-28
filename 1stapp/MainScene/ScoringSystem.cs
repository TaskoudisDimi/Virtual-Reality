using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
    //private int score;

    void OnTriggerEnter(Collider other)
    {


        theScore += 50;
        scoreText.GetComponent<Text>().text = "SCORE:" + theScore;
        Debug.Log("Hit good ball");
        Destroy(gameObject);
    }

}
