using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			GetComponent<FadeOut>().shouldFade = true;
		}
	}
}
