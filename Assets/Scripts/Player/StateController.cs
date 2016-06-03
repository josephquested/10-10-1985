using UnityEngine;
using System.Collections;

public class StateController : MonoBehaviour {
	[SerializeField] Rigidbody rb;
	public bool canMove;
	public bool isMoving;

	public void IsMoving (bool state) {
		isMoving = state;
	}

	public void CanMove (bool state) {
 		canMove = state;
	}
}
