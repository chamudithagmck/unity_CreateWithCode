using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float horizontalInput;

    public GameObject projectilePrafabs;



    public float xRange = 20;



    void Start()
    {
        
    }//Start






    void Update()
    { 

        // Left & Right Bounderies
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }  

        if(transform.position.x > xRange)
        {

            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Player Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        //Player Movements
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile From the Player
            Instantiate(projectilePrafabs, transform.position, projectilePrafabs.transform.rotation);

        }





    }//Update


}//Class
