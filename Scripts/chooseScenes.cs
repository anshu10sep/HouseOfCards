using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Class used for choosing a different scene from within an active
 * scene
 */

public class chooseScenes : MonoBehaviour {

	public GameObject level ;
	float i;

	void Start () {
		i = 0f;
	}

	public void chooseScene(string sceneName){
		Application.LoadLevelAsync (sceneName);
	}
	void Update () {

	}

}
