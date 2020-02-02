using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forceUnit;
    public float maxVelocity;
    public Rigidbody2D myRigidbody;
    [SerializeField] private Transform playerGraphics;

    void Update()
    {
        Vector3 resultingVector = new Vector3(0,0,0);
        Vector3 up = new Vector3(0,1,0);
        Vector3 right = new Vector3(1,0,0);

        if (Input.GetAxis("Vertical")>0)
        {
            resultingVector+=(forceUnit*up);
        }
        if (Input.GetAxis("Vertical")<0)
        {
            resultingVector+=(-1*forceUnit*up);
        }
        if (Input.GetAxis("Horizontal")>0)
        {
            resultingVector+=(forceUnit*right);
            if(transform.rotation.y != 1)
            {
                transform.Rotate(Vector2.up, 180);
            }
        }
        if (Input.GetAxis("Horizontal")<0)
        {
            resultingVector+=(-1*forceUnit*right);
            if (transform.rotation.y != 0)
            {
                transform.Rotate(Vector2.up, -180);
            }
        }
      
        myRigidbody.AddForce(resultingVector);
        if(myRigidbody.velocity.magnitude > maxVelocity)
        {
            myRigidbody.velocity*=maxVelocity/myRigidbody.velocity.magnitude;
        }
    }
}
