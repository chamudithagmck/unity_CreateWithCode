using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{

    public float topBound = 40;
    public float lowerBound = -20;
  
    void Update()
    {
        //Food cookie 
        if(transform.position.z > topBound)
        {
            Destroy(this.gameObject);
        }

        //Animals
        if(transform.position.z < lowerBound)
        {
            Destroy(this.gameObject);
        }


    }//Update


}//Class
