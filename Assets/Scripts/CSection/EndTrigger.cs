using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {
	public AudioSource natureAudio;
	public AudioSource playerAudio;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			GetComponent<FadeOut>().shouldFade = true;
			StartCoroutine(FadeOutAudio());
		}
	}

	IEnumerator FadeOutAudio ()
	{
		while (natureAudio.volume >= 0 && playerAudio.volume >= 0)
		{
			natureAudio.volume -= 0.001f;
			playerAudio.volume -= 0.001f;
			print("fading");
			yield return new WaitForSeconds(0.01f);
		}
		print("done fading!");
	}
}
