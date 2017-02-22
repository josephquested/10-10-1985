using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpermRain : MonoBehaviour {
	public GameObject spermPrefab;
	public float frequency;
	public bool shouldSperm;

	void Update () {
		if (shouldSperm)
		{
			StartCoroutine(SpawnSperm());
		}
	}

	IEnumerator SpawnSperm ()
	{
		shouldSperm = false;
		print("spawned");
		Vector3 position = new Vector3 (Random.Range(-2700, 4700), 500, Random.Range(-2800, 2600));
		var sperm = Instantiate(spermPrefab, position, transform.rotation);
		yield return new WaitForSeconds(frequency);
		Destroy(sperm, 60);
		shouldSperm = true;
	}
}
