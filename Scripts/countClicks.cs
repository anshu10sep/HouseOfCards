using System.Collections;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;


/*
 * Class used to count the total number of clicks
 */

public class countClicks : MonoBehaviour {

	public Text counter;
	public int c;


	// Use this for initialization
	void Start () {
		counter = GetComponent<Text> () as Text;

	}

	// Update is called once per frame
	void Update () {
		//c = select.count;
		c = 8 - select.localCount;
		counter.text = "Cards Left:"+c.ToString("00");
	}
}
