using UnityEngine;
using System.Collections;

public class GroundTrigger : MonoBehaviour {

	[SerializeField] GroundSpotlight spotlight;

	void OnTriggerEnter (Collider collider) {
		if (collider.CompareTag("Player")) {
			spotlight.Activate();
		}
	}
}
