using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamemode;
using System.Threading;

namespace Gamemode
{
    public class PlayerMove : MonoBehaviour
    {

        public CharacterController controller;
        public Animator animator;

        public float runSpeed = 40f;

        float horizontalMove = 0f;
        bool jump = false;
        bool crouch = false;

        // Update is called once per frame
        void Update()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
                animator.SetBool("IsJumping", true);
            }

            if (Input.GetButtonDown("Crouch"))
            {
                crouch = true;
            }
        }

        public void OnLanding()
        {
            animator.SetBool("IsJumping", false);
        }

        void FixedUpdate()
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
            jump = false;
        }
    }

}
