using UnityEngine;
using System.Collections;

public class InteractionController : MonoBehaviour {
	[SerializeField] StateController stateController;
	[SerializeField] InteractionTrigger interactionTrigger;

	public void Use () {
		GameObject target = interactionTrigger.GetTarget();
		if (target != null) {
			// Target.Function()
		}
	}
}
