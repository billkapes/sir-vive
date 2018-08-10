using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bob : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//transform.DORotate(new Vector3(-45, -1, 45), 1).SetEase(Ease.Linear).SetLoops(-1);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(transform.up, 100 * Time.deltaTime);
	}
}
