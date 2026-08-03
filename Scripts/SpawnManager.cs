using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrafabs;

    private float spawnRangeX = 20;
    private float spawnPositionZ = 30;

    private float startDelay = 1;
    private float spawnInterval = 0.5f;
    void Start()
    {

        InvokeRepeating("SpawnRandomAnimal", startDelay , spawnInterval);
        
    }//Start


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
       
       

    }//Update

    void SpawnRandomAnimal()
    {

        int animalIndex = Random.Range(0, animalPrafabs.Length);


        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);


        Instantiate(animalPrafabs[animalIndex], spawnPos, animalPrafabs[animalIndex].transform.rotation);

    }





}//Class
