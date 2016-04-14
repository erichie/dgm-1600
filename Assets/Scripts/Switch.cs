using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	public int myCase = 19;

	// Use this for initialization
	void Start () {

		// Using a switch statement
		switch(myCase) {
			case 1:
				Debug.Log ("My favorite number is 1!");
				break;
			case 4:
				Debug.Log ("My favorite number is 4!");
				break;
			default:
				Debug.Log ("I don't have a favorite number!");
				break;
		}
	}
}
