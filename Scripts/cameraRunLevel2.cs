using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script used to move the camera wherever the subject is looking.
 */
public class cameraRunLevel2 : MonoBehaviour {

	void Start () {

	}

	// Update is called once per frame, thread, run continously
	void Update () {
		
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast (transform.position, fwd, 10)) {

		} else {

		}
	}
}
