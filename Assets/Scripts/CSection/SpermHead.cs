using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpermHead : MonoBehaviour {
	AudioSource audio;
	public AudioClip[] sounds;

	void Start ()
	{
		audio = GetComponent<AudioSource>();
		AudioClip clip = sounds[Random.Range(0, sounds.Length)];
		audio.clip = clip;
		audio.loop = true;
		audio.pitch = Random.Range(-3, 3);
		audio.Play();
	}
}
