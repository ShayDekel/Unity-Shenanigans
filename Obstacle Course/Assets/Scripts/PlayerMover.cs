using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 8f;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player with input
        UpdateMovement();
    }

    private void UpdateMovement()
    {
        float xVlaue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; // Get horizontal movement
        float zVlaue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; // Get vertical movement
        transform.Translate(xVlaue, 0f, zVlaue); 
    }
}
