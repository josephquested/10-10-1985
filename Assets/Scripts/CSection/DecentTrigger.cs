using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecentTrigger : MonoBehaviour {
	public AudioSource fatherAudio;
	public Cock cock;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			fatherAudio.Play();
			cock.primed = true;
		}
	}
}
