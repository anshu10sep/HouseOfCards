using System.Collections;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

/*
 * Class to calculate the time user have spent in playing the game.
 */

public class timerScript : MonoBehaviour {

	public Text counter;
	public static float seconds, minutes;

	// Use this for initialization
	void Start () {
		counter = GetComponent<Text> () as Text;
	}
	
	// Update is called once per frame
	void Update () {
		minutes = (int)(Time.timeSinceLevelLoad / 60f);
		seconds = (int)(Time.timeSinceLevelLoad % 60f);
		counter.text = minutes.ToString ("00") + ":" + seconds.ToString ("00");
	}
}
