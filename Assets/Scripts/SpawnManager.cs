using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject player;


    public float accelerationRate; 
    public float maxSpeed; 
    private float currentSpeed; 

    // Start is called before the first frame update
    void Start()
    {
         currentSpeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed += accelerationRate * Time.deltaTime;
        currentSpeed = Mathf.Min(currentSpeed, maxSpeed);
        transform.position += new Vector3(currentSpeed * Time.deltaTime, 0f, 0f);
    }
}
