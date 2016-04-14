using UnityEngine;
using System.Collections;

public class Enums : MonoBehaviour {

	// Declaring an enum
	enum Days {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};

	enum Seasons {Winter=1, Fall=2, Spring=3, Summer=4};

	enum Importance : int {None, Trivial, Important, Critical};

	// Use this for initialization
	void Start () {
		int warmestSeason = (int)Seasons.Summer;
		Debug.Log (warmestSeason);

		Days newDay = nextDay (Days.Monday);
		Debug.Log (newDay);
	}

	// Using Enums in a function
	Days nextDay (Days day) {
		if (day == Days.Sunday) {
			day = Days.Monday;
		} else {
			day += 1;
		}
		return day;
	}
}
