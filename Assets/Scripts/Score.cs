using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public playerMovement player; // Accessing playerMovement script to import the score
    public Text scoreText; // Reference to the text to be edited
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Display score until the player wins then display "You Won!!"
        if (player.Score < 10)
        {
            scoreText.text = "Score = " + player.Score.ToString();
        }
        else
        {
            scoreText.text = "You Won! ";
        }
    }
}
