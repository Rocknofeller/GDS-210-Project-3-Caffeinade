using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Wave[] waves;
    public GameObject customer;

    Wave currentWave;
    int currentWaveNumber;

    int customerRemainingToSpawn;
    float nextSpawnTime;

    void Update()
    {
        if (customerRemainingToSpawn > 0 && Time.time > nextSpawnTime)
        {
            customerRemainingToSpawn--;
            nextSpawnTime = Time.time + currentWave.timeBetweenSpawns;

            GameObject spawnedCustomer = Instantiate(customer, Vector3.zero, Quaternion.identity) as GameObject;
        }
    }

    void NextWave()
    {
        currentWaveNumber ++;
        currentWave = waves[currentWaveNumber - 1];

        customerRemainingToSpawn = currentWave.CustomerCount;
    }

    [System.Serializable]
    public class Wave
    {
        public int CustomerCount;
        public float timeBetweenSpawns;
    }
}
