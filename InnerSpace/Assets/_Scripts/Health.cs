using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;

    public GameObject explosionEffect;
    public AudioClip shipKersplode;

    public GameObject scoreScript;
    public LevelManager myLevelManager;



    public int GetHealth()
    {
        return health;
    }

    public void DecrementHealth()
    {
        health--;
        scoreScript.GetComponent<Scoreboard>().AdjustLives();
    }

    public void IncrementHealth()
    {
        health++;
        scoreScript.GetComponent<Scoreboard>().AdjustLives();
    }
        
    // If ship collides with anything, decrement health
    void OnCollisionEnter2D(Collision2D collider)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        DecrementHealth();
    }

    // Update is called once per frame
    void Update () {

        if (health <= 0)
        {
            // Destroy ship
            Destroy(gameObject);
            // Make kersplosion
            Instantiate(explosionEffect, transform.position, Quaternion.identity);

            // Play kersplosion sound
            AudioSource.PlayClipAtPoint(shipKersplode, Camera.main.transform.position);

           myLevelManager.LoadLevel("GameOver");
        }
	}
}
