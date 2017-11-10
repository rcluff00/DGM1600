using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

     public float rotationSpeed;
    public float thrustForce;

    public GameObject projectile;
    public Transform shotPos;
    public float shotForce;

    // Use this for initialization
    void Start () {

    }
	

	// Update is called once per frame
	void Update () {

        // check for up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * thrustForce * Input.GetAxis("Vertical"));
        }

        // check for left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        }

        // check for right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        }



        if (Input.GetKey(KeyCode.Space))
        {
            GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
            shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
        }

    }
}
