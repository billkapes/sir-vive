using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
	bool touched;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			if (!touched) {
				touched = true;
				GetComponent<MeshRenderer>().material.color = Color.green;
				transform.parent.GetComponent<BoardManager>().count += 1;
			}
		}
	}
}
