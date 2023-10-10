using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //array to store UFO ships

    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPOs= new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
            
            int ufoIndex = Random.Range(0, ufoPrefabs.Length); // picks a random ufo from the array
            Instantiate(ufoPrefabs[ufoIndex], spawnPOs, ufoPrefabs[ufoIndex].transform.rotation); 
            //spawns a indexed ufo from the array at a random location on the x axis
        }
    }
}
