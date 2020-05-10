using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
    public Rigidbody rb;

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
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
