using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameController.Mover += movimiento;
	}
	
	private void movimiento () {
		gameObject.GetComponent<Transform> ().position = gameObject.GetComponent<Transform> ().position  * GameObject.Find ("Player").GetComponent<PlayerCollision> ().power / 1000;
		//gameObject.GetComponent<Rigidbody>().AddForce(GameObject.Find ("Player").GetComponent<PlayerCollision> ().power / 100 * Time.deltaTime, 0, 0);
	}
}
