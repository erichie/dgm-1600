using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

	public int age;
	private int deathAge = 100;
	private int[] ageOfFriends = {10, 14, 12, 17};

	void Start() {
		while (age < deathAge) {
			Debug.Log ("Player is alive.");
			age++;
		}
		Debug.Log ("Player is dead.");

		do {
			Debug.Log (age);
		} while(age < deathAge);

		for (int i = 50; i < deathAge; i++) {
			Debug.Log ("Player is awesome");
		}

		foreach (int ages in ageOfFriends) {
			Debug.Log (ages);
		}
	}
}
