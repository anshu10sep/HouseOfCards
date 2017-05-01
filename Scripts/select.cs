using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Class that have main logic and bain for the application.
 * The functions are called when a card is clicked. The flipping
 * of cards and flipping back is handeled here. All the card matching 
 * operations are done in this class.
 */

public class select : MonoBehaviour {

	// Use this for initialization
	public static int count = 0;
	static GameObject lastCard = null;
	public GameObject plane = null;
	Renderer rend;
	bool cor = true;
	public static int localCount = 0;
	public Material[] material;
	void Start () {
		rend = gameObject.GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material[0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void choose(){
		count++;
		rend = gameObject.GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [1];
		StartCoroutine(Example1());
		//print ("flag1.4");
	}

	IEnumerator Example1(){
		if (lastCard != null && gameObject.name.Contains (lastCard.name.Substring (0, 3))) {
			//print ("flag 11");
			yield return new WaitForSeconds(0.5f);
			//print ("flag 12");
			//yield return new WaitForSeconds(0.5f);
			//print ("flagg");
			if (!lastCard.Equals (gameObject)) {
				rend = gameObject.GetComponent<Renderer> ();
				rend.transform.Rotate (new Vector3 (0f, 0f, Time.deltaTime * 10));
				lastCard.active = false;
				gameObject.active = false;
				cameraRunMaze.updateOn = true;
				localCount = localCount + 2;
				if (localCount == 8) {
					plane.transform.position = plane.transform.position + new Vector3 (0f, -150f, 0f);
					//print ("in");
					//yield return new WaitForSeconds(0.5f);
					Application.LoadLevelAsync ("gameOver");
					//print ("flag2");

				}
			} else {
				rend = gameObject.GetComponent<Renderer> ();
				rend.enabled = true;
				rend.sharedMaterial = material [0];
				lastCard = gameObject;
				//print ("flag1.3");
			}
		} else {
			yield return new WaitForSeconds(0.5f);
			rend = gameObject.GetComponent<Renderer> ();
			rend.enabled = true;
			rend.sharedMaterial = material [0];
			//print ("flag1.2");
		}
		//print ("flag1.1");
		lastCard = gameObject;
	}
}
