using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    //1000 ms for each second 
    void Update()
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
    }
}
