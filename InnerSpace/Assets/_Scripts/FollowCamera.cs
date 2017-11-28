using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public Transform objectToFollow;
    public float zOffset;
	
	// Update is called once per frame
	void Update () {
        // Creat myPos, follow object.position
        Vector3 myPos = objectToFollow.position;

        // Change z to zoffset
        myPos.z = zOffset;

        //Set this transorm position to myPos
        gameObject.transform.position = myPos;
	}
}
