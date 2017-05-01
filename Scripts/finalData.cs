using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Class used for showin the total number of clicks
 * when the game is over
 */
public class finalData : MonoBehaviour {
	public Text counter;
	public float seconds, minutes;
	int count = 0;
	// Use this for initialization
	void Start () {
		counter = GetComponent<Text> () as Text;
	}

	// Update is called once per frame
	void Update () {
		count = select.count;
		counter.text = "Total Clicks::  "+  count.ToString ("00") ;
	}
}
