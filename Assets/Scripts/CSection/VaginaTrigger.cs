using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VaginaTrigger : MonoBehaviour {
	public FadeOutAudio audio1;
	public FadeOutAudio audio2;
	public FadeOutAudio audio3;

	void OnTriggerEnter (Collider collider) {
		if (collider.tag == ("Player"))
		{
			audio1.FadeOut();
			audio2.FadeOut();
			audio3.FadeOut();
			GetComponent<AudioSource>().Play();
			GetComponent<FadeOut>().shouldFade = true;
			StartCoroutine(ChangeScene());
		}
	}

	IEnumerator ChangeScene ()
	{
		yield return new WaitForSeconds(8f);
		SceneManager.LoadScene("meadow");
	}
}
