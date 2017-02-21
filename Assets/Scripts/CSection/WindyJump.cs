using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindyJump : MonoBehaviour {
	CharacterController cc;
	AudioSource sound;

	void Start () {
		cc = transform.parent.gameObject.GetComponent<CharacterController>();
		sound = GetComponent<AudioSource>();
	}

	void Update () {
		if (!cc.isGrounded)
		{
			sound.Play();
		}
		else
		{
			sound.Stop();
		}
	}
}
