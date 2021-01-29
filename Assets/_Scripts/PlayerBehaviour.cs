using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public float jumpForce;
    public Rigidbody rigidbody;
    public bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    //1000 ms for each second 
    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                //move to the right 

                rigidbody.AddForce(Vector3.right * movementForce);
            }
            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                //move to the left
                rigidbody.AddForce(Vector3.left * movementForce);

            }

            if (Input.GetAxisRaw("Vertical") > 0)
            {
                //move forward

                rigidbody.AddForce(Vector3.forward * movementForce);
            }
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                //move backwards
                rigidbody.AddForce(Vector3.back * movementForce);

            }
            if (Input.GetAxisRaw("Jump")>0)
            {
                //jump
                rigidbody.AddForce(Vector3.up * jumpForce);
            }
        }
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }

    }

}
