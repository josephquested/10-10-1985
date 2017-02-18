using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VaginaTrigger : MonoBehaviour {
	void OnTriggerEnter (Collider collider) {
		if (collider.tag == ("Player"))
		{
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
