using UnityEngine;
using System.Collections;

public class GroundSpotlight : MonoBehaviour {

	[SerializeField] int timeDelay;
	[SerializeField] Light spotlight;
	[SerializeField] Transform playerTransform;

	public void Activate () {
		StartCoroutine(ActivateSpotlightDelay(timeDelay));
	}

	IEnumerator ActivateSpotlightDelay (int time) {
		yield return new WaitForSeconds(time);
		ToggleLights(true);
	}

	public void ToggleLights (bool state) {
		spotlight.enabled = state;
	}
}
