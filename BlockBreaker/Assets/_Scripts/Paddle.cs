using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public float paddleHeight;

    private Transform paddleTrans;


	// Use this for initialization
	void Start () {
        paddleTrans = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
        // get mouse position, translating to world coordinates
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // override vertical y position to keep it on a flat, side to side plane
        mousePos.y = paddleHeight;
        // override z depth position
        mousePos.z = 0;
        // apply coordinates to paddle
        paddleTrans.position = mousePos;
	}
}
