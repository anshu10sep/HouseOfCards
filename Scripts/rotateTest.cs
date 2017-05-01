using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class used to rotate an object around the z-axis
 * This is basically used to rotate cards around camera
 */

public class rotateTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(Vector3.zero, Vector3.up, 20f * Time.deltaTime);
	}
}
