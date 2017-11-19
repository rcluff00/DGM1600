using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    public Sprite[] myGraphics;
    private int hitCount = 0;
    private LevelManager myLevelManager;

    public int theBrickCount;

    void OnCollisionEnter2D (Collision2D collider) {
        // Take away health
        health--;
        hitCount++;

        // If health is < 0, destroy the brick
        if (health <= 0) {
            LevelManager.brickCount--;
            myLevelManager.CheckBrickCount();
            Destroy(this.gameObject);
        }

        GetComponent<SpriteRenderer>().sprite = myGraphics[hitCount];
    }

	// Use this for initialization
	void Start () {
        myLevelManager = FindObjectOfType<LevelManager>();
	}

    void Update ()
    {
        theBrickCount = LevelManager.brickCount;
    }
}
