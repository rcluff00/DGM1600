using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    public enum Type {SpeedBoost, SpeedDown, Shield};
    public Type PowerupType;
    public Sprite[] images;

    private int powerupRandom;

	// Use this for initialization
	void Start () {

        powerupRandom = Random.Range(0, 3);

        switch (powerupRandom)
        {
            case 0:
                PowerupType = Type.SpeedBoost;
                break;
            case 1:
                PowerupType = Type.SpeedDown;
                break;
            case 2:
                PowerupType = Type.Shield;
                break;
            default:
                break;
        }

        //change powerup image
        switch (PowerupType)
        {
            case Type.SpeedBoost:
                gameObject.GetComponent<SpriteRenderer>().sprite = images[0];
                break;
            case Type.SpeedDown:
                GetComponent<SpriteRenderer>().sprite = images[1];
                GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
                break;
            case Type.Shield:
                GetComponent<SpriteRenderer>().sprite = images[2];
                GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);
                break;
            default:
                break;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            switch (PowerupType)
            {
                case Type.SpeedBoost:
                    other.GetComponent<PlayerController>().thrustForce *= 2;
                    other.GetComponent<PlayerController>().rotationSpeed *= 2;
                    break;
                case Type.SpeedDown:
                    other.GetComponent<PlayerController>().thrustForce /= 2;
                    other.GetComponent<PlayerController>().rotationSpeed /= 2;
                    break;
                case Type.Shield:
                    other.GetComponent<Health>().health++;
                    break;
                default:
                    break;
            }

            Destroy(this.gameObject);
        }
    }


	// Update is called once per frame
	void Update () {
		
	}
}
