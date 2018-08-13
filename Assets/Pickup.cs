using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {
	int[] randomPos = new int[] {-4, -2, 0, 2, 4};
	public ParticleSystem spray;
	public GameObject bomb;
	bool isBomb;

	// Use this for initialization
	void Start () {
		isBomb = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Instantiate(spray, transform.position + Vector3.up, Quaternion.identity );
			if (isBomb) {
				Instantiate(bomb, transform.position, Quaternion.identity);
				isBomb = false;
			}
			Vector3 tempPos = transform.position;
			do {
				transform.position = new Vector3(randomPos[Random.Range(0, randomPos.Length)], 0, randomPos[Random.Range(0, randomPos.Length)]);
				
			} while (tempPos == transform.position);
			if (Random.Range(0, 3) == 2) {
				isBomb = true;
				transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.black;
			} else {
				transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.yellow;

			}
		}
		//Destroy(gameObject);
	}
}
