using conner;
using UnityEngine;

namespace conner
{
    public class PlayerMovement : MonoBehaviour
    {

        public CharacterController2D controller;
        public float runSpeed = 40f;
        float horizontalMove = 0f;
        bool jump = false;
        bool crouch = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        void Update()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            if(Input.GetButton("Jump"))
            {
                jump = true;
            }

            if(Input.GetButton("Crouch"))
            {
                crouch = true;
            }
            if(crouch == true && !Input.GetButton("Crouch"))
            {
                crouch = false;
            }

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
            jump = false;
        }
    }
}
