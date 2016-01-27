using UnityEngine;
using System.Collections;

public class VariablesFunctions : MonoBehaviour {
	int sum;

	// Use this for initialization
	void Start () {
		sum = addTwoNumbers (7, 4);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int addTwoNumbers(int x, int y) {
		int sum = x + y;
		return sum;
	}
}
