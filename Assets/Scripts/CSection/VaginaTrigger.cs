using UnityEngine;
using System.Collections;

public class VaginaTrigger : MonoBehaviour {

	[SerializeField] InteractionController interactionController;

	void OnTriggerEnter (Collider collider) {
		if (collider.CompareTag("Player")) {
			interactionController.InitiateWombTransition();
		}
	}
}
