﻿using UnityEngine;
using gggyjw;

namespace gggyjw
{
    public class PlayerCollision : MonoBehaviour
    {

        public PlayerMovement playerMovement;

        void OnCollisionEnter(Collision collisionInfo)
        {
            if (collisionInfo.collider.tag == "Obstacle")
            {
                playerMovement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}