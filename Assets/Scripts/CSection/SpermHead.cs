using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpermHead : MonoBehaviour {
	AudioSource spermAudio;
	public AudioClip[] sounds;

	void Start ()
	{
		spermAudio = GetComponent<AudioSource>();
		AudioClip clip = sounds[Random.Range(0, sounds.Length)];
		spermAudio.clip = clip;
		spermAudio.loop = true;
		spermAudio.pitch = Random.Range(-3, 3);
		spermAudio.Play();
	}
}
