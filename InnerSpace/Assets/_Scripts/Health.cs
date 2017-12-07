using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    public GameObject explosionEffect;
    public GameObject[] lives;

    public int GetHealth()
    {
        return health;
    }


    void Start()
    {
        for (int i = 0; i < health; i++)
        {
            lives[i].SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        health--;
    }

    // Update is called once per frame
    void Update () {

        

        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }
	}
}
