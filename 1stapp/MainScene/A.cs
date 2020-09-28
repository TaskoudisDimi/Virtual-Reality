using UnityEngine;
using UnityEngine.SceneManagement;
public class A : MonoBehaviour
{

    public Roll movement;
    public float delayBeforeLoading = 1000f;
    //public string sceneNameToLoad;
    public float timeElapsed;

    void OnCollisionEnter(UnityEngine.Collision col)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (col.gameObject.name == "Bad1")
        {
            Debug.Log("Game Over");
            Destroy(col.gameObject,1f);
            movement.enabled = false;
            Application.LoadLevel(2);
        }
        if (col.gameObject.name == "Bad2")
        {
            Debug.Log("Game Over");
            Destroy(col.gameObject, 1f);
            movement.enabled = false;
            Application.LoadLevel(2);
        }
        if (col.gameObject.name == "Bad3")
        {
            Debug.Log("Game Over");
            Destroy(col.gameObject, 1f);
            movement.enabled = false;
            Application.LoadLevel(2);
        }
        if (col.gameObject.name == "Bad4")
        {
            Debug.Log("Game Over");
            Destroy(col.gameObject, 1f);
            movement.enabled = false;
            Application.LoadLevel(2);
        }

        if (col.gameObject.name == "FinalGame")
        {
            Debug.Log("Final Game");
            movement.enabled = false;
            Application.LoadLevel(2);
        }
    }
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)
        {
            Application.LoadLevel(2);
        }
    }
}

