using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

    public float InitialRotationSpeed;
    public ParticleSystem explosionEffect;
    public AudioClip meteorKersplode;

    public int pointWorth = 1;

    public int meteorSpeed;
    public GameObject thePlayer;
    public Scoreboard scoreScript;

    void Start () {
        scoreScript = FindObjectOfType<Scoreboard>();

        // Start Meteors out spinning a lil bit
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-InitialRotationSpeed, InitialRotationSpeed), ForceMode2D.Impulse);

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
            // Play kersplosion sound
            AudioSource.PlayClipAtPoint(meteorKersplode, Camera.main.transform.position);

            // if it collides with a laser
            if (collider.gameObject.tag == "Laser")
            {
                //Destroy laser
                Destroy(collider.gameObject);

                // Increase score
                scoreScript.GetComponent<Scoreboard>().IncrementScoreboard(pointWorth);
            }
        }
            

        

        



    }
}
