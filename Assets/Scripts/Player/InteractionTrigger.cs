using UnityEngine;
using System.Collections;

public class InteractionTrigger : MonoBehaviour {
	public GameObject target;

	void OnTriggerEnter (Collider collider) {
		// if (collider.CompareTag("Trigger")) {
		// 	collider.SendMessageUpwards("Function", true);
		// 	target = collider.gameObject;
		// }
	}

	void OnTriggerExit (Collider collider) {
		// if (collider.CompareTag("Trigger")) {
		// 	collider.SendMessageUpwards("Function", false);
		// 	target = null;
		// }
	}

	public GameObject GetTarget () {
		return target;
	}
}
