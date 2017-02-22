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
		natureAudio.volume -= 0.01f;
		playerAudio.volume -= 0.01f;
		yield return new WaitForSeconds(0.01f);
	}
}
