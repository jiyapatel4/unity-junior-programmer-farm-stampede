using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // an array of game objects
    public GameObject[] animalPrefabs;

    // spawn coordinate vars
    private int spawnRangeX = 10;
    private int spawnPosZ = 20;

    // spawn delay vars
    private int startDelay = 2;
    private float spawnDelay = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // call the method after 2 seconds every 1.5 seconds
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnDelay);

    }

    // Update is called once per frame
    void Update()
    {
            
        
    }
    
    // method that will spawn random animals
    void SpawnRandomAnimal()
    {
        // pick a random index value between 0 and and 3
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // create a new Vector3 object where the x value is generated randomly between a specific range
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // create instances of random animals at random locations in the game scene
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
