using UnityEngine;

namespace ashz
{
    public class PlayerCollision : MonoBehaviour
    {
        public PlayerMovement playerMovement;

        void OnCollisionEnter(Collision collisionInfo)
        {
            //Debug.Log(collisionInfo.collider.name);
            if(collisionInfo.collider.tag == "Obstacle")
            {
                //Debug.Log("We hit a obstacle");
                playerMovement.enabled = false;
            }
        }
    }
}
 