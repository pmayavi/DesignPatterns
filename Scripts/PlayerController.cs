using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 200f;

    void Update()
    {
        // Get horizontal and vertical input (arrow keys or WASD)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput).normalized;

        // Move the player in the calculated direction
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
    }
}
