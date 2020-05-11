using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;

namespace ashz
{
    public class PlayerMovement : MonoBehaviour
    {
        public Rigidbody rb;
        public float forwardForce = 2000f;
        public float sidewaysForce = 500f;

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
            rb.AddForce(/*X*/0, /*Y*/0, /*Z*/forwardForce * Time.deltaTime);
            if ( Input.GetKey("d") )
            {
                rb.AddForce( sidewaysForce * Time.deltaTime, 0, 0);
            }
            if ( Input.GetKey("a") )
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
            }
        }
    }
}
