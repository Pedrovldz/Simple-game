using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   
    //This is a reference to the Rigidbody component called RB.
    public Rigidbody rb;

    //Created a variable for the foward force, so it can be changed in the unity hub
    public float FowardForce = 2000f;

    public float SidewaysForce = 500f;

    // Update is called once per frame]
    //The prefix "Fixed" in "FixedUpdate" is used when you're messing with physics.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, FowardForce * Time.deltaTime); //Add a foward force

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
