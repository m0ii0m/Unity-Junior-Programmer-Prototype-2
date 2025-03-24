using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private int minSpawnInterval = 3;
    private int maxSpawnInterval = 5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InvokeSpawnRandomBall", startDelay, minSpawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        GameObject ball = ballPrefabs[Random.Range(0, ballPrefabs.Length)];
        // instantiate ball at random spawn location
        Instantiate(ball, spawnPos, ball.transform.rotation);
    }

    void InvokeSpawnRandomBall()
    {
        if(!IsInvoking("SpawnRandomBall"))
        {
            Invoke("SpawnRandomBall", Random.Range(0, maxSpawnInterval - minSpawnInterval + 1));
        }
    }

}
