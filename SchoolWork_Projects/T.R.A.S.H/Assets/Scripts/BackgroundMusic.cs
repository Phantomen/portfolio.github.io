﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {


    private AudioSource audioSource;
	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

	}
	
	// Update is called once per frame
	void Update ()
    {
        //if (Input.GetKeyDown("space"))
        //{
        //audioSource.Stop();
        //}
            

    }

    public void StopMusic()
    {
        audioSource.Stop();
    }

}
