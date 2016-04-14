using UnityEngine;
using System.Collections;
using System;

public class ClassesDataTypes : MonoBehaviour {

	// Creating a class
	public class Enemy {

		// Default Constructor
		public Enemy() {
			Debug.Log ("Enemy Constructor.");
		}
		
		public void attack() {
			Debug.Log ("Enemy Attack!!!");
		}
	}

	// Creating a sub class
	public class Goblin : Enemy {
		
		public int health;

		// Contstructor with parameters
		public Goblin(int goblinHealth) {
			health = goblinHealth;
		}
		
		public void goblinAttack() {
			Debug.Log ("Goblin Attack!!!");
		}

		public void showGoblinHealth() {
			Debug.Log (health);
		}
	}

	// Creating instances of a class
	public Enemy enemy = new Enemy();
	public Goblin goblin = new Goblin(100);
	
	void Start () {
		enemy.attack();
		goblin.goblinAttack ();
		goblin.showGoblinHealth ();
	}
}
