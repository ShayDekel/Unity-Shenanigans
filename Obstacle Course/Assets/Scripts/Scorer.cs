using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    int playerScore = 0;

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit")
        {
            playerScore++;
            Debug.Log("Score: " + playerScore);
        }
    }
}
