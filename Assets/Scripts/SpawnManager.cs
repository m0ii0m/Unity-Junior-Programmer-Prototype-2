using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    float spawnRangeX = 20;
    float spawnRangeZ = 20;
    float startDelay = 2;
    float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        // Randomly generate animal index and spawn position
        GameObject animal = animalPrefabs[Random.Range(0, animalPrefabs.Length)];
        Instantiate(animal, new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ), animal.transform.rotation);
    }
}
