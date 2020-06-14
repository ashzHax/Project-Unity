using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ashz {
    public class PlayerMovement : MonoBehaviour
    {
        public CharacterController2D myCharacterController;
        public Animator myAnimator;
        public float forwardSpeed = 50f;

        private bool playerJump = false;
        private bool playerCrouch = false;
        private float horizontalMove = 0f;

        private void Update()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * forwardSpeed;
            //Debug.Log(horizontalMove);

            myAnimator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            if (Input.GetButtonDown("Jump"))
            {
                playerJump = true;
                myAnimator.SetBool("isJumping", true);
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

        public void OnLanding()
        {
            myAnimator.SetBool("isJumping", false);
        }

        public void OnCrouching(bool isCrouching)
        {
            myAnimator.SetBool("isCrouching", isCrouching);
        }

        private void FixedUpdate()
        {
            myCharacterController.Move(horizontalMove * Time.fixedDeltaTime, playerCrouch, playerJump);
            if (playerJump) playerJump = false;
        }
    }
}
