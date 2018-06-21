using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    Vector3 ve;

    public float ballSpeed;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ve = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {


        ve.x = -ballSpeed * Input.GetAxis("Horizontal");

        ve.z = -ballSpeed * Input.GetAxis("Vertical");
       
        rb.AddForce(ve, ForceMode.Acceleration);
    }
}
