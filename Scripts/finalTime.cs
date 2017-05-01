using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Class ued to display time when the game is over
 */
public class finalTime : MonoBehaviour {

	public Text counter;
	public float seconds, minutes;

	// Use this for initialization
	void Start () {
		counter = GetComponent<Text> () as Text;
	}

	// Update is called once per frame
	void Update () {
		minutes = timerScript.minutes;
		seconds = timerScript.seconds;
		counter.text = "Total Time :: " + minutes.ToString ("00") + ":" + seconds.ToString ("00");
	}
}
