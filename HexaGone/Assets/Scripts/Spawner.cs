using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject hexagonPrefab;

    public float spawnRate = 1f;
    private float nextTimeToSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTimeToSpawn)
        {
            // provjeriti ima li još života prije spawnanja novog hexagona
            // ili
            // provjeriti dali je hexagon pogodio playera
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;

            // TODO:
            // svaki 5. hexagon druge boje (score + 1)
        }
    }
}
