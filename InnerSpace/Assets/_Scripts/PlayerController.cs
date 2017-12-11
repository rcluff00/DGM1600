using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

     public float rotationSpeed;
    public float thrustForce;

    public GameObject projectile;
    public Transform shotPos;
    public float shotForce;


    public ParticleSystem myParticles;

    // Use this for initialization
    void Start () {

        print(GetComponent<Health>().GetHealth());
    }
	

	// Update is called once per frame
	void Update () {

        // Rotate the ship if necessary
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal")*
            rotationSpeed * Time.deltaTime);
 
        // Thrust the ship if necessary
        GetComponent<Rigidbody2D>().
            AddForce(transform.up * thrustForce *
                Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.UpArrow))
        {
            myParticles.Emit(1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
            shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
        }



        }
}
