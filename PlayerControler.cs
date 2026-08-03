using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float Speed = 20.0f;
    public float turnspeed ;

    public float horizontalInput;
    public float forwardInput;

    void Start()
    {
        
    }//STRAT

    // Update is called once per frame
    void Update()
    {
        //Move Vehical Forward
        horizontalInput  = Input.GetAxis("Horizontal");

        //Move Vehical 
        forwardInput = Input.GetAxis("Vertical"); 

        //Forward
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);

       
        //Rotation
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
    }

}//update