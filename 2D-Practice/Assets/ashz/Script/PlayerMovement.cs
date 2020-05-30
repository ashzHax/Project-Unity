using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace ashz
{
    public class PlayerMovement : MonoBehaviour
    {

        public CharacterController2D controller;
        private float horizontalMove = 0f;
        public float runSpeed = 40f;
        private bool jump = false;

        void Update()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            // Debug.Log(Input.GetAxisRaw("Horizontal"));
            if(Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        }

        void FixedUpdate()
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            if (jump) jump = false;
        }

    }
}

