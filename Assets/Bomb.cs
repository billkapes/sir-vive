using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
	float timer;

	// Use this for initialization
	void Start () {

	}

	void Awake() {
		timer = 0f;	
		Destroy(gameObject, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one * 15f, timer);
		timer += Time.deltaTime;
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Bullet") {
			Destroy(other.gameObject);
		}
	}

}
