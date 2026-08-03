using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefabs;

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController _playerControllerScript;


    void Start()
    {
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();


        InvokeRepeating("SapwnObstacle", startDelay, repeatRate); 
    }

  
    void SapwnObstacle()
    {

        if(_playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefabs, spawnPos, obstaclePrefabs.transform.rotation);
        }
          
    }
}
