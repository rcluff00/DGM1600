using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    public GameObject explosionEffect;

    public Scoreboard scoreScript;

    public int GetHealth()
    {
        return health;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        health--;
        
    }

    // Update is called once per frame
    void Update () {

        if (health <= 0)
        {
            // Destroy ship
            Destroy(gameObject);
            // Make kersplosion
            Instantiate(explosionEffect, transform.position, Quaternion.identity);

            scoreScript.DecrementLives();
        }
	}
}
