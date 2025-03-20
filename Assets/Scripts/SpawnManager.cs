using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    float spawnRangeX = 20;
    float spawnRangeZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            // Randomly generate animal index and spawn position
            GameObject animal = animalPrefabs[Random.Range(0, animalPrefabs.Length)];
            Instantiate(animal, new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ), animal.transform.rotation);
        }
    }
}
