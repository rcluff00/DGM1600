using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

     public float RotateSpeed;

    public GameObject projectile;
    public Transform shotPos;
    public float shotForce;
    //public float moveSpeed;

    // Use this for initialization
    void Start () {

    }
	

	// Update is called once per frame
	void Update () {

        // check for up
        if (Input.GetKey(KeyCode.UpArrow))
        {

        }

        // check for down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
        }

        // check for left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Rotate(Vector3.forward * (RotateSpeed * Time.deltaTime));
        }

        // check for right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Rotate += new Vector3 (0,0, RotateSpeed * Time.deltaTime);
        }



        if (Input.GetButtonUp("Fire1"))
        {
            GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
            shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
        }

    }
}
