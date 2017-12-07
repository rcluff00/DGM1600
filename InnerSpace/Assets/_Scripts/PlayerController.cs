﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

     public float rotationSpeed;
    public float thrustForce;

    public GameObject projectile;
    public Transform shotPos;
    public float shotForce;


    public ParticleSystem myParticles;

    // Use this for initialization
    void Start () {

        print(GetComponent<Health>().GetHealth());
    }
	

	// Update is called once per frame
	void Update () {

        // check for up
        if (Input.GetKey(KeyCode.UpArrow))
        {

            //add torque?

            GetComponent<Rigidbody2D>().AddForce(transform.up * thrustForce * Input.GetAxis("Vertical"));
            myParticles.Emit(1);
        }

        // check for left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        }

        // check for right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
            shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
            
        }

       

    }
}
