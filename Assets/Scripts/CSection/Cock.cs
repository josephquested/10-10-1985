using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cock : MonoBehaviour {
	public Transform urethra;
	public GameObject spermPrefab;
	public float stamina;
	public bool canCum;
	public int quantity;

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
		Cum();
		canCum = true;
	}

	void Cum ()
	{
		for (int i = 0; i < quantity; i++)
		{
			var sperm = Instantiate(spermPrefab, urethra.position, urethra.rotation);
			Vector3 ejaculation = Vector3.forward;
			float force = Random.Range(1, 10);
			sperm.GetComponent<Rigidbody>().AddForce(ejaculation * force);
		}
	}
}
