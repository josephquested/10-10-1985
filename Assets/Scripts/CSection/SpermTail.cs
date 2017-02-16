using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpermTail : MonoBehaviour {
	Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		Vector3 movement = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
		rb.AddForce(movement);
	}
}
