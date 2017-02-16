using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecentTrigger : MonoBehaviour {
	public Animator fatherAnimator;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			print("triggered!");
			fatherAnimator.speed = 1;
		}
	}
}
