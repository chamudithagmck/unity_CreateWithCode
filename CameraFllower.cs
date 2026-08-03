using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFllower : MonoBehaviour
{

    public GameObject player;

    public Vector3 offset = new Vector3(-155.6f, 91.08f, -20.06f);

   
    void Update()
    {

        transform.position = player.transform.position + offset;
    
    }//Update
}
