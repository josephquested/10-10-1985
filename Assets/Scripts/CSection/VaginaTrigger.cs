using UnityEngine;
using System.Collections;

public class VaginaTrigger : MonoBehaviour {

	void OnTriggerEnter (Collider collider) {
		if (collider.CompareTag("Player")) {
		}
	}
}
