using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public GameObject paddle;
    public Vector3 paddleToBallVector;

    private bool started = false;
    private Rigidbody2D MyRigidBody;

    // Use this for initialization
    void Start () {
        paddleToBallVector = this.transform.position - paddle.transform.position;
        MyRigidBody = this.GetComponent<Rigidbody2D> ();
    }
	
	// Update is called once per frame
	void Update () {
        if(started != true){
            this.transform.position = paddle.transform.position + paddleToBallVector;

            //if push start button
            if(Input.GetMouseButtonDown(0)){
                //ball starts flying
                MyRigidBody.velocity = new Vector2(2,20);
                //started = true
                started = true;
            }
        }

    }
}
