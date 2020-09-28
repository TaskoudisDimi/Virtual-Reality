using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q : MonoBehaviour
{
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Application.LoadLevel(1);
    }
    public void Exitgame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
