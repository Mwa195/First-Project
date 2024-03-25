using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjects : MonoBehaviour
{
    public GameObject obstacle; // Reference to the object to be randomly generated
    public int numberOfObjects = 9; // # of objects - 1
    void Start()
    {
        // Generate objects randomly
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Randomize Position within set parameters
            Vector3 randomPosition = new Vector3( Random.Range(-9,9) , Random.Range(2,2) , Random.Range(-9,9) );

            // Generate objects at random positions
            Instantiate(obstacle, randomPosition, Quaternion.identity);
        }
    }
}