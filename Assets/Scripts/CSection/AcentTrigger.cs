using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcentTrigger : MonoBehaviour {
	public GameObject terrain;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			DestroyWorld();
		}
	}

	void DestroyWorld ()
	{
		Destroy(terrain);
	}
}
