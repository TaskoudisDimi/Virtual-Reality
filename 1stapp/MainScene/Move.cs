using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 100f;
    private float vrROLL;
    Vector3 pos;


    public Transform vrCamera;

    private void FixedUpdate()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0 );



        float vrROLL = Camera.main.transform.eulerAngles.z;
        if (vrROLL >= (20) && vrROLL <= (80))
        {
            transform.Translate(-0.1f, 0f, 0f);
            checkBOUNDS();
            Debug.Log("Left");

        }
        if (vrROLL <= (340) && vrROLL >= (280))
        {
            transform.Translate(0.1f, 0f, 0f);
            checkBOUNDS();
            Debug.Log("Right");
        }
    }
    void checkBOUNDS()
    {
        if (Camera.main.transform.position.x < (-120))
        {
            transform.localPosition = new Vector3(-30f, 0f, 0f);
            Debug.Log("Hit Left Wall");
            //FindObjectOfType<Game>().EndGame();

        }
        if (Camera.main.transform.position.x > (120))
        {
            transform.localPosition = new Vector3(30f, 0f, 0f);
            Debug.Log("Hit Right Wall");
        }

    }
}
