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

        //入力を受け取る
        ve.x = -ballSpeed * Input.GetAxis("Horizontal");
        ve.z = -ballSpeed * Input.GetAxis("Vertical");
        
        //入力された方向に力を加える
        
    }
}
