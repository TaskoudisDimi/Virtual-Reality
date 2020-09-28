using UnityEngine;

public class Move2 : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;


    //public Transform vrCamera;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

    }

}
