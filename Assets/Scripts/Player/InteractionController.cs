using UnityEngine;
using System.Collections;

public class InteractionController : MonoBehaviour {
	[SerializeField] StateController stateController;
	[SerializeField] InteractionTrigger interactionTrigger;
	[SerializeField] SceneFadeInOut fadeController;

	public void Use () {
		GameObject target = interactionTrigger.GetTarget();
		if (target != null) {
			// Target.Function()
		}
	}

	public void InitiateWombTransition () {
		print("I should fade!");
		fadeController.FadeToBlack();
	}
}
