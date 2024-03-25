using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    public Rigidbody rb; // Naming our player's component to access later
    public float Force = 50; // Force of Movement
    public int Score; // Game score
    private string lastCollidedObj; // A variable to store the Tag of the last collided object
    
    // On player colliding event the following instructions are executed
    void OnCollisionEnter(Collision info)
    {
        lastCollidedObj = info.collider.tag; // Storing the tag in the variable
        //Checking if the player collided with an obstacle to destroy it
        if (info.gameObject.CompareTag("Obstacle"))
        {
            Destroy(info.gameObject); // Destroy the object
            Score += 1; // Increase the score
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start");
    }

    
    // Update is called once per frame
    void FixedUpdate()
    {
        /*Player Movement
        Forward -> w
        Backward -> s
        Right -> d
        Left -> a
        Jump -> f
        */ 
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, Force*10*Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(Force*10*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0-Force*10*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, 0-Force*10*Time.deltaTime);
        }
        // The player can only jump it is on the ground
        if (Input.GetKey("f") && lastCollidedObj == "Plane" && transform.position.y == 0.5)
        {
            rb.AddForce(0, Force/5, 0, ForceMode.Impulse);
        }
    }
}
