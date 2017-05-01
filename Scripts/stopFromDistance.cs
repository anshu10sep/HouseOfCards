using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * class is used to stop the movement of the camera from the distance
 * when an object (cards in this appication) is selected from 20 untits.
 */

public class stopFromDistance : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void stopWalk(){
		cameraRunMaze.updateOn = false;
	}

	public void startWalk(){
		cameraRunMaze.updateOn = true;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
