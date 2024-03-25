using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollower : MonoBehaviour
{
    private bool flag; // A flag to switch betwen First Person and Third Person
    public Transform player; // Referencing to our player
    public Vector3 offset; // Third Person Perspective Offset
    public Vector3 offset2; // Rear view Offset
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Camera Perspective
        if (flag ==  false)
        {
            transform.position = player.position; // First Person
        }
        else
        {
            transform.position = player.position + offset; // Third Person
        }

        // Trigger button for changing perspectives is set to p
        if (Input.GetKeyDown("p"))
        {
            if(transform.position == player.position)
            {
                flag = true;
            }
            else if(transform.position == player.position + offset)
            {
                flag = false;
            }
        }
        
        // Camera Rotation
        Quaternion rotation = new(0, 180, 0, 0); // A rotation variable for reversing
        Quaternion normal = new(0, 0, 0, 0); // Normal rotation variable
        if (Input.GetKey("r"))
        {
            transform.position = player.position + offset2;
            transform.rotation = rotation;
        }
        else
        {
            transform.rotation = normal;
        }
    }
}
