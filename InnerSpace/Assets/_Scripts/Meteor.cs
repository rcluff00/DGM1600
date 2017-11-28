using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

    public float InitialRotationSpeed;

	void Start () {
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-InitialRotationSpeed, InitialRotationSpeed), ForceMode2D.Impulse);
	}
	
	void Update () {
		
	}
}
