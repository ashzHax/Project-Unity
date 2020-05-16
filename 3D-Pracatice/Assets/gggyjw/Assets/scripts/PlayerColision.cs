using UnityEngine;
using gggyjw;

namespace gggyjw
{
    
    public class PlayerColision : MonoBehaviour
    {
        public PlayerMovement movement;

        void OnCollisionEnter(Collision collisionInfo)
        {
            if (collisionInfo.collider.name == "obstacle")
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
                
            }
        }
    }
}