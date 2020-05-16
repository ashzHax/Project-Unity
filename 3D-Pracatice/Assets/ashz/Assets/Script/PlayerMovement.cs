using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace ashz
{
    public class PlayerMovement : MonoBehaviour
    {
        public Rigidbody rb;
        public float forwardForce = 2000f;
        public float sidewaysForce = 500f;
        private bool gameOver = false;

        // Start is called before the first frame update
        /*
        void Start()
        {
            //rb.useGravity = false;
            rb.AddForce(0, 200, 500);
        }
        */

        // Update is called once per frame
        /*
        void Update()
        {
            rb.AddForce(0, 0, 2000 * Time.deltaTime);
        }
        */

        // FixedUpdate is prefered when changing physics (more smoother)
        void FixedUpdate()
        {
            if (gameOver) return;

            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame();
                gameOver = true;
            }

            rb.AddForce(/*X*/0, /*Y*/0, /*Z*/forwardForce * Time.deltaTime);
            
            if ( Input.GetKey("d") )
            {
                //rb.AddForce( sidewaysForce * Time.deltaTime, 0, 0);
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if ( Input.GetKey("a") )
            {
                //rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
    }
}
