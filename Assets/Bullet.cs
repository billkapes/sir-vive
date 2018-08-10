using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bullet : MonoBehaviour {
	float timer = 0f;
	public ParticleSystem appearParticle;

	// Use this for initialization
	void Start () {
		Instantiate (appearParticle, transform.position, transform.rotation);

		Sequence mySequence = DOTween.Sequence();
		mySequence.Append(transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 1));
		mySequence.Append(transform.DOScaleZ(Random.Range(0.5f, 3f), 1));
		Invoke("SetVelocity", 1f);
	}
	
	// Update is called once per frame
	void Update () {
		//transform.localScale = Vector3.Lerp (Vector3.one / 10f, Vector3.one / 2f, timer);
		//timer += Time.deltaTime;
	}

	void SetVelocity() {
		GetComponent<Rigidbody>().velocity = transform.forward * 4f;
		GetComponent<Rigidbody>().angularVelocity = transform.forward * 3f;

	}
}
