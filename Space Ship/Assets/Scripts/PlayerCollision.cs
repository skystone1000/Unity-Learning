using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            Debug.Log("Collision: " + collision.collider.name);
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
