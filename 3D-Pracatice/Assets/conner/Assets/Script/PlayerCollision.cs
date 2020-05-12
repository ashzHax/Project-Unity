using JetBrains.Annotations;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    { 
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We Hit Obstacle !");
            movement.enabled = false;
        }
    }
}
