using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class used to rotate an object around the z-axis
 * This is basically used to rotate cards aound there own axis
 */

public class rotateMazeCards : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3 (0f, Time.deltaTime * 30f, 0f));
	}
}
