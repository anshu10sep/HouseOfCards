using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script used to move the camera wherever the subject is looking.
 */

public class cameraRun : MonoBehaviour {
	
	public static bool updateOn = true;
	void Start () {
		
	}
	
	// Update is called once per frame, thread, run continously
	void Update () {
		if (updateOn == true) {
			transform.position = transform.position + Camera.main.transform.forward * Time.deltaTime * 1.5f;
		}
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast (transform.position, fwd, 10)) {
			
		} else {
			
		}
	}
}
