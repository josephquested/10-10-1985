using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecentTrigger : MonoBehaviour {
	public GameObject father;
	public AudioSource fatherAudio;
	public Cock cock;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			father.SetActive(true);
			fatherAudio.Play();
			cock.primed = true;
		}
	}
}
