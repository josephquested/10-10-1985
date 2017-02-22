using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CreditSequence : MonoBehaviour {
	public FadeText text1;
	public FadeText text2;
	public FadeText text3;

	public FadeText button1;
	public FadeText button2;
	public FadeText divider;

	bool canClick = false;

	void Start () {
		StartCoroutine(RunCredits());
	}

	IEnumerator RunCredits ()
	{
		yield return new WaitForSeconds(13f);
		text1.FadeIn();
		yield return new WaitForSeconds(5f);
		text1.FadeOut();
		yield return new WaitForSeconds(5f);
		text2.FadeIn();
		yield return new WaitForSeconds(5f);
		text2.FadeOut();
		yield return new WaitForSeconds(5f);
		text3.FadeIn();
		yield return new WaitForSeconds(5f);
		text3.FadeOut();
		yield return new WaitForSeconds(5f);
		canClick = true;
		button1.FadeIn();
		button2.FadeIn();
		divider.FadeIn();
	}

	public void Restart ()
	{
		if (canClick)
		{
			SceneManager.LoadScene("conception");
		}
	}

	public void Quit ()
	{
		if (canClick)
		{
			Application.Quit();
		}
	}
}
