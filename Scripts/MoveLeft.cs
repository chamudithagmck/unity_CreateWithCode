using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10;

    private PlayerController _playerControllerScript;
    void Start()
    {
        
    }

    
    void Update()
    {
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        if(_playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if(transform.position.x < -10 && gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }
           



        
    }
}
