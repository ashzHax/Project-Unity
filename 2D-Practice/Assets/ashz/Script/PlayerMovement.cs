using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ashz {
    public class PlayerMovement : MonoBehaviour
    {
        public CharacterController2D myCharacterController;
        public float forwardSpeed = 50f;

        private bool playerJump = false;
        private bool playerCrouch = false;
        private float horizontalMove = 0f;

        private void Update()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * forwardSpeed;
            //Debug.Log(horizontalMove);

            if (Input.GetButtonDown("Jump"))
            {
                playerJump = true;
            }
            if (Input.GetButtonDown("Crouch"))
            {
                playerCrouch = true;
            } 
            else if (Input.GetButtonUp("Crouch"))
            {
                playerCrouch = false;
            }
        }

        private void FixedUpdate()
        {
            myCharacterController.Move(horizontalMove * Time.fixedDeltaTime, playerCrouch, playerJump);
            if (playerJump) playerJump = false;
        }
    }
}
