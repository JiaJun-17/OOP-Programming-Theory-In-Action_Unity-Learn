using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeZLeft = -3.0f;
    private float spawnRangeZRight = 2.8f;
    private float spawnPositionY = 4.0f;
    private float spawnInterval = 2.0f;
    private float startDelay = 1.0f;

    public GameObject[] objectPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        int objectIndex = Random.Range(0, objectPrefabs.Length);
        Vector3 spawnPosition = new Vector3(0, spawnPositionY, Random.Range(spawnRangeZLeft, spawnRangeZRight));

        Instantiate(objectPrefabs[objectIndex], spawnPosition, objectPrefabs[objectIndex].transform.rotation);
    }

}
