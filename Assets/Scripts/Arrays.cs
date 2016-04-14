using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	// Declaring an array
	public int[] numbers;

	// Declaring and initializing an array on the same line
	public string[] names = {"Edward", "Frank", "Joe", "Bruce", "Steve"};

	// Use this for initialization
	void Start () {
		// Initializing an array
		numbers = new int[10];

		// Accessing an item in the array
		Debug.Log (names[0]);

		// Using a for loop to add items to an array
		for (int i = 0; i < 10; i++) {
			numbers[i] = i * 2;
		}

		// Using a for loop to print the items of an array
		for (int i = 0; i < numbers.Length; i++) {
			Debug.Log (numbers[i]);
		}
	}
}
