using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    public Text ScoreText;

    public Transform player;
    //public GameObject scoreText;


    public static int theScore;
    private int score;
    // Start is called before the first frame update
    void Start()
    {

        theScore = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

        ScoreText.text = "Score: " + player.position.z.ToString("0") + (int)theScore;
        



    }
}
