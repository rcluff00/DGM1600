using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    public float laserSpeed;
    public float lifetime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lifetime -= Time.deltaTime;

        if (lifetime <= 0)
        {
            Destroy(this.gameObject);
        }

        transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);
	}
}
