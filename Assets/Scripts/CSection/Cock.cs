using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cock : MonoBehaviour {
	AudioSource audio;

	public Transform urethra;
	public GameObject spermPrefab;
	public float stamina;
	public bool canCum;
	public int quantity;
	public bool primed;

	public AudioClip passiveMoan;
	public AudioClip ejaculatoryGroan;

	void Start ()
	{
		audio = GetComponent<AudioSource>();
	}

	void Update ()
	{
		if (canCum)
		{
			StartCoroutine(CumRoutine());
		}
	}

	IEnumerator CumRoutine ()
	{
		canCum = false;
		yield return new WaitForSeconds(stamina);
		if (primed)
		{
			StartCoroutine(Cum());
		}
		canCum = true;
	}

	IEnumerator Cum ()
	{
		audio.clip = ejaculatoryGroan;
		audio.Play();
		for (int i = 0; i < quantity; i++)
		{
			var sperm = Instantiate(spermPrefab, urethra.position, urethra.rotation);
			Vector3 ejaculation = Vector3.forward;
			float force = Random.Range(1, 200);
			sperm.GetComponent<Rigidbody>().AddForce(ejaculation * force);
			Destroy(sperm, 40f);
			yield return new WaitForSeconds(0.03f);
		}
		audio.clip = passiveMoan;
		audio.Play();
	}
}
