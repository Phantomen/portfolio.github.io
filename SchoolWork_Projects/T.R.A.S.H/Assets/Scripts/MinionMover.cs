﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionMover : MonoBehaviour {

    public int speed = 1;

    Rigidbody2D rigidbody;


	// Use this for initialization
	void Start ()
    {
        rigidbody = transform.gameObject.GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.up * speed;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rigidbody.velocity = transform.up * speed;
    }
}
