using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 40f;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("w")){
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("a")) { 
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s")){
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        if(rb.position.y < -3f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
