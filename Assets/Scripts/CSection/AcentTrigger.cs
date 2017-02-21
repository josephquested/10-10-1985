using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcentTrigger : MonoBehaviour {
	public GameObject terrain;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			StartCoroutine(DestroyWorld());
		}
	}

	IEnumerator DestroyWorld ()
	{
		yield return new WaitForEndOfFrame();
		Destroy(terrain);
	}
}
