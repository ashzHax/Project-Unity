using UnityEngine;
using gggyjw;

public class PlayerCcolision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.name == "obstacle")
        {
            movement.enabled = false;
        }
    }
}
