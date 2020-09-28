using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel(1);
    }
    public void Exitgame()
    { 
        Application.Quit();
        Debug.Log("Quit");
    }

}