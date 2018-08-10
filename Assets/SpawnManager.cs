using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
	float timer;
	int spawnAmount;

	// Use this for initialization
	void Start () {
		timer = 3.3f;
		spawnAmount = 1;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer < 0f) {
			for (int i = 0; i < spawnAmount; i++) {
				transform.GetChild(Random.Range(0, transform.childCount)).SendMessage("DoSpawn");
			}
			timer = 3.3f;
			spawnAmount += 1;
		}
	}

}
