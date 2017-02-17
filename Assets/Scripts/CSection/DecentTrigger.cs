using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecentTrigger : MonoBehaviour {
	public Animator fatherAnimator;
	public Cock cock;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			cock.primed = true;
		}
	}
}
