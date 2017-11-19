using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    public enum Type {SpeedBoost, LaserSplay, Shield, west};
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
                break;
            case Type.Shield:
                break;
            case Type.west:
                break;
            default:
                break;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("We hit a powerup");

        switch (PowerupType)
        {
            case Type.SpeedBoost:
                other.GetComponent<PlayerController>().thrustForce *= 2;
                break;
            case Type.LaserSplay:
                break;
            case Type.Shield:
                break;
            case Type.west:
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
