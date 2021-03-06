﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forceUnit;
    public float maxVelocity;
    public Rigidbody2D myRigidbody;
    [SerializeField] private Transform playerGraphics;
    public ParticleSystem explosao,explosao2;
    public AudioSource puff1, puff2;
    private Vector3 target;

    void Start()
    {
        explosao.emissionRate = 0;
        explosao2.emissionRate = 0;
    }

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
        }
        if (Input.GetAxis("Horizontal")<0)
        {
            resultingVector+=(-1*forceUnit*right);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            puff1.Play();
            puff2.Play();
            explosao.Emit(10);
            explosao2.Emit(10);
        }

        DetermineRotation(resultingVector);

        myRigidbody.AddForce(resultingVector);
        if(myRigidbody.velocity.magnitude > maxVelocity)
        {
            myRigidbody.velocity*=maxVelocity/myRigidbody.velocity.magnitude;
        }
    }

    private void DetermineRotation(Vector3 resultingVector)
    {
        if(resultingVector.x < 0)
        {
            if(resultingVector.y > 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, -45));
            }
            else if (resultingVector.y < 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 45));
            }
            else if(resultingVector.y == 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
        }
        else if(resultingVector.x > 0)
        {
            if (resultingVector.y > 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, -45));
            }
            else if (resultingVector.y < 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 45));
            }
            else if (resultingVector.y == 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            }
        }
        else if (resultingVector.x == 0)
        {
            if (resultingVector.y > 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.y, -90));
            }
            else if (resultingVector.y < 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.y, 90));
            }
        }
    }
}
