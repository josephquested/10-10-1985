using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	public bool shouldFade;

	public Texture2D fadeTexture;
	public float fadeSpeed = 0.2f;
	public int drawDepth = -1000;

	private float alpha = 0.0f;
	private int fadeDir = -1;


	void OnGUI()
	{
		if (shouldFade)
		{
			alpha -= fadeDir * fadeSpeed * Time.deltaTime;
			alpha = Mathf.Clamp01(alpha);

			Color thisAlpha = GUI.color;
			thisAlpha.a = alpha;
			GUI.color = thisAlpha;

			GUI.depth = drawDepth;

			GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), fadeTexture);
		}
	}
}
