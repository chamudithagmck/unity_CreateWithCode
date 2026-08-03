using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private float repeatWidth;
    private Vector3 startPos;
   
    void Start()
    {
        startPos = transform.position;

        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    
    void Update()
    {
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }

    }
}
