using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script used to move the camera wherever the subject is looking.
 * This is different from Camera run script as this has various 
 * different fuctionalaties. This is specific to level 5 of
 * the application.
 */

public class cameraRunMaze : MonoBehaviour {

	public static bool updateOn = true;
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		if (updateOn == true) {
			
			transform.position = transform.position + Camera.main.transform.forward * Time.deltaTime * 2.0f;
		}		
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast (transform.position, fwd, 20)) {
			
		}
			
	}

}
