using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] Perfabs;
    public GameObject player;
    private float spawnRangeX = 8;
    private float spawnPosZ = 20;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, Perfabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(Perfabs[animalIndex],spawnPos, Perfabs[animalIndex].transform.rotation);
        }
    }
}
