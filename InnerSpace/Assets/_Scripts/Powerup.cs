using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    public enum Type {SpeedBoost, LaserSplay, Shield};
    public Type PowerupType;
    public Sprite[] images;
    


	// Use this for initialization
	void Start () {
        
        //change powerup image
        switch (PowerupType)
        {
            case Type.SpeedBoost:
                gameObject.GetComponent<SpriteRenderer>().sprite = images[0];
                break;
            case Type.LaserSplay:
                GetComponent<SpriteRenderer>().sprite = images[1];
                break;
            case Type.Shield:
                GetComponent<SpriteRenderer>().sprite = images[2];
                break;
            default:
                break;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        switch (PowerupType)
        {
            case Type.SpeedBoost:
                other.GetComponent<PlayerController>().thrustForce *= 2;
                other.GetComponent<PlayerController>().rotationSpeed *= 2;
                break;
            case Type.LaserSplay:
                other.GetComponent<Laser>().laserSpeed *= 2;
                break;
            case Type.Shield:
                other.GetComponent<Health>().health++;
                break;
            default:
                break;
        }

        Destroy(this.gameObject);
    }


	// Update is called once per frame
	void Update () {
		
	}
}
