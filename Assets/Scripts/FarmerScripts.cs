using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerScripts : MonoBehaviour
{
    public float speed = 2.5f;
    private Rigidbody Farmer;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Farmer = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        Farmer.AddForce((player.transform.position - transform.position).normalized * speed);
    }
}
