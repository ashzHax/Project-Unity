using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace gggyjw
{
    public class PlayerMovement : MonoBehaviour
    {

        public CharacterController2D controller;

        public float runSpeed = 40f;
        
        bool Jump = false;

        float horizontalMove = 0f;

        void Update()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            if (Input.GetButtonDown("Jump"))
            {
                Jump = true;
            }
        }

         void FixedUpdate()
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, Jump);
            Jump = false;

        }
    }
}
