using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

    public float InitialRotationSpeed;
    public ParticleSystem explosionEffect;

    public int pointWorth = 1;

    public int meteorSpeed;
    public GameObject thePlayer;

    void Start () {

        // Start Meteors out spinning a lil bit
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-InitialRotationSpeed, InitialRotationSpeed), ForceMode2D.Impulse);
        //GetComponent<Rigidbody2D>().AddForce(transform.up * Random.Range(-50.0f, 150.0f));

        launchMeteor();
    }
	
	void Update () {
		
	}

    void launchMeteor()
    {
        GetComponent<Rigidbody2D>().AddForce((thePlayer.transform.position - transform.position) * meteorSpeed);
    }
    

    // When a meteor collides
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag != "Meteor")
        {
            // Destroy meteor
            Destroy(gameObject);

            // Make kersplosion
            Instantiate(explosionEffect, transform.position, Quaternion.identity);

            // if it collides with a laser
            if (collider.gameObject.tag == "Laser")
            {
                //Destroy laser
                Destroy(collider.gameObject);

                // Increase score
                GetComponent<Scoreboard>().IncrementScoreboard(pointWorth);
            }
        }
            

        

        



    }
}
