
using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //disable movement
            FindObjectOfType<Manager>().EndGame();
        }

        if (collisionInfo.collider.tag == "finalPlatform")
        {
            movement.enabled = false; //disable movement
            FindObjectOfType<Manager>().GameWin();

        }
        
    }

}
