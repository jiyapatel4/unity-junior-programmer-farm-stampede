using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    // an array of game objects
    public GameObject[] animalPrefabs;

    // spawn coordinate vars
    private Vector3 spawnPosition;
    private int spawnRangeX = 10;
    private int spawnPosZ = 20;

    private int horizontalSpawnRange = 21;
    private int spawnRangeZTop = 13;
    private int spawnRangeZBottom = 2;

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
        // pick a random index value
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // animals spawning ahead
        if (animalIndex == 0 || animalIndex == 1 || animalIndex == 2)
        {
            // create a new Vector3 object where the x value is generated randomly between a specific range
            spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        }
        // animals spawning from the left
        else if (animalIndex == 3 || animalIndex == 4 || animalIndex == 5)
        {
            spawnPosition = new Vector3(-horizontalSpawnRange, 0, Random.Range(spawnRangeZBottom, spawnRangeZTop));
        }
        // animals spawning from the right
        else
        {
            spawnPosition = new Vector3(horizontalSpawnRange, 0, Random.Range(spawnRangeZBottom, spawnRangeZTop));
        }
        

        // create instances of random animals at random locations in the game scene
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
