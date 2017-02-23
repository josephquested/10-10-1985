using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutAudio : MonoBehaviour {
	public void FadeOut ()
	{
		StartCoroutine(FadeOutRoutine());
	}

	IEnumerator FadeOutRoutine ()
	{
		print("fading out");
		AudioSource music = GetComponent<AudioSource>();
		while (music.volume > 0)
		{
			music.volume -= 0.1f;
			yield return new WaitForSeconds(0.1f);
		}
	}
}
