using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    private float vrROLL;
    Vector3 pos;


    public Transform vrCamera;
    public float toggleAngle = 3.0f;
    public float speed = 100.0f;
    public bool moveForward;
    private CharacterController cc;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }



    // Update is called once per frame
    void Update()
    {
        float vrROLL = Camera.main.transform.eulerAngles.z;
        if (vrROLL >= (20) && vrROLL <= (80))
        {
            transform.Translate(-1f, 0f, 0f);
            checkBOUNDS();
            Debug.Log("Left");

        }
        if (vrROLL <= (340) && vrROLL >= (280))
        {
            transform.Translate(1f, 0f, 0f);
            checkBOUNDS();
            Debug.Log("Right");
        }
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }


    }

    void checkBOUNDS()
    {
        if (Camera.main.transform.position.x < (-200))
        {
            transform.localPosition = new Vector3(-30f, 0f, 0f);
            //Debug.Log("GAME OVER");
            //FindObjectOfType<Game>().EndGame();
            Debug.Log("Hit Left Wall");


        }
        if (Camera.main.transform.position.x > (200))
        {
            transform.localPosition = new Vector3(30f, 0f, 0f);
            //Debug.Log("GAME OVER");
            //FindObjectOfType<Game>().EndGame();
            Debug.Log("Hit Right Wall");
        }

    }
}
