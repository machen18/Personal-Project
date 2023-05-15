using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 8f;
    private float xBound = 7.5f;
    public float jumpForce = 5.0f;
    
    public float accelerationRate;
    public float maxSpeed;

    private bool isGrounded = true;
    private Rigidbody playerRb;
    private float currentSpeed;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    

        currentSpeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition(); 

        //if (transform.position.z > transform.position.z

    // The Player Jump
    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        

        currentSpeed += accelerationRate * Time.deltaTime;
        currentSpeed = Mathf.Min(currentSpeed, maxSpeed);
        transform.position += new Vector3(currentSpeed * Time.deltaTime, 0f, 0f);
    }

    // Moves the player based on arrow key input
void MovePlayer()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");

        //playerRb.AddForce(Vector3.forward * speed * verticalInput);
        //playerRb.AddForce(Vector3.right * speed * horizontalInput);
        if (Input.GetKey(KeyCode.A)) {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    //Prevent the player from leaving the top + bottom of screen
    void ConstrainPlayerPosition()
    {
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
    }

}
