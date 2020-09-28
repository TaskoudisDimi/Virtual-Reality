using UnityEngine;
using UnityEngine.SceneManagement;


public class Game : MonoBehaviour
{
    bool gameHasEnded = false;
    //public float restartDelay = 2f;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            //Debug.Log("GAME OVER");
            //Invoke("Restart or Quit", restartDelay);
            Restart();
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
