using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPlus : MonoBehaviour
{
    public GameObject[] powerupModels; // List of power-up models to swap between
    public GameObject[] obstacleModels; // List of obstacle models to swap between
    public float spawnCycle = 0.5f;

    private GameManager manager;
    private float elapsedTime;
    private bool spawnPowerup = true;
    private float nextSwapTime = 10f; // Time for the next model swap
    private int currentPowerupIndex = 0; // Track which power-up model is currently used
    private int currentObstacleIndex = 0; // Track which obstacle model is currently used

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        // Handle model swap every 10 seconds
        if (Time.time >= nextSwapTime)
        {
            SwapModels();
            nextSwapTime += 10f; // Schedule next swap
        }

        // Spawn logic
        if (elapsedTime > spawnCycle)
        {
            GameObject temp;
            if (spawnPowerup)
                temp = Instantiate(powerupModels[currentPowerupIndex]); // Spawn current power-up model
            else
                temp = Instantiate(obstacleModels[currentObstacleIndex]); // Spawn current obstacle model

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;

            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;

            elapsedTime = 0;
            spawnPowerup = !spawnPowerup;
        }
    }

    void SwapModels()
    {
        currentPowerupIndex = (currentPowerupIndex + 1) % powerupModels.Length; // Cycle through power-ups
        currentObstacleIndex = (currentObstacleIndex + 1) % obstacleModels.Length; // Cycle through obstacles
    }
}