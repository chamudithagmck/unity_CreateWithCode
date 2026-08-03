using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   void OnTriggerEnter(Collider target)
    {
       // Cookie 
        Destroy(this.gameObject);

        //Animals
        Destroy(target.gameObject);


    }
}
