using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

    public float InitialRotationSpeed;
    public ParticleSystem explosionEffect;

    void Start () {
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-InitialRotationSpeed, InitialRotationSpeed), ForceMode2D.Impulse);
	}
	
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        Destroy(collider.gameObject);
        Destroy(gameObject);
        Instantiate(explosionEffect, transform.position, Quaternion.identity);


    }
}
