using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

    public float InitialRotationSpeed;
    public ParticleSystem explosionEffect;

    public int pointWorth = 1;

    void Start () {
        // Start Meteors out spinning a lil bit
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-InitialRotationSpeed, InitialRotationSpeed), ForceMode2D.Impulse);
	}
	
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        // Destroy meteor
        Destroy(gameObject);

        // Make kersplosion
        Instantiate(explosionEffect, transform.position, Quaternion.identity);

        if (collider.gameObject.tag == "Laser")
        {
            //Destroy laser
            Destroy(collider.gameObject);

            // Increase score
        }



    }
}
