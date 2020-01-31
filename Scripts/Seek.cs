﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek
{
    public GameObject target; //target
    public Kinematic character; //char

    public float maxAcceleration = 15f;
	public Vector3 offset = new Vector3(4f,0,-4f);


    public SteeringOutput getSteering()
    {
        SteeringOutput result = new SteeringOutput();
        result.linearVelocity = ((target.transform.position + offset) - character.transform.position) ;

        // give full acceleration along this direction
        result.linearVelocity.Normalize();
        result.linearVelocity *= maxAcceleration;

        result.angularVelocity = 0;
        return result;
    }
}