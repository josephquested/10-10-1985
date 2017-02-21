using UnityEngine;
using System.Collections;

public class GroundTrigger : MonoBehaviour {

	[SerializeField] GroundSpotlight spotlight;
	public GameObject fallAudio;

	void OnTriggerEnter (Collider collider) {
		if (collider.CompareTag("Player")) {
			Destroy(fallAudio);
			GameObject.FindWithTag("Player").GetComponent<FirstPersonController>().ChangeFootsteps();
			spotlight.Activate();
			Destroy(this);
		}
	}
}
