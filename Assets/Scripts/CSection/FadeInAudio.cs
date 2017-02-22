using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInAudio : MonoBehaviour {
	void Start () {
		StartCoroutine(FadeIn());
	}

	IEnumerator FadeIn()
	{
		yield return new WaitForSeconds(1f);
		AudioSource music = GetComponent<AudioSource>();
		while (music.volume < 1)
		{
			music.volume += 0.001f;
			yield return new WaitForSeconds(0.01f);
		}
	}
}
