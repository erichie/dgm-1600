using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {
	
	private bool walking;
	private int runningSpeed = 50;

	public int speed;

	void Update()
	{
		if (speed == 0) {
			Debug.Log ("Player is standing.");
		} else if (speed > 0 && speed < runningSpeed) {
			Debug.Log ("Player is walking");
		} else if (speed == runningSpeed) {
			Debug.Log ("Player is running");
		} else {
			Debug.Log("Player is dead");
		}
	}
}
