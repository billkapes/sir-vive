using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject bulletPrefab, simpleBulletPrefab;
	public Vector3 direction;


	public int waitTime;
	 
	// Use this for initialization
	void Start () {
		//Invoke("SpawnBullet", Random.Range(1f, 10f));
		waitTime = 50;
		StartCoroutine("SpawnSimpleBullet");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnBullet() {
		//yield return new WaitForSeconds (Random.Range(1f, waitTime));
		Instantiate (bulletPrefab, transform.position, transform.rotation);	
		yield return new WaitForSeconds (1f);
		//bullet.GetComponent<Rigidbody> ().velocity = direction;
		//Invoke("SpawnBullet", Random.Range(1f, 10f));
		//waitTime = Mathf.Max(1, waitTime - 1);
		//StartCoroutine("SpawnBullet");


	}

	IEnumerator SpawnSimpleBullet() {
		yield return new WaitForSeconds (Random.Range(1f, waitTime));
		Instantiate (simpleBulletPrefab, transform.position, transform.rotation);	
		yield return new WaitForSeconds (1f);
		//bullet.GetComponent<Rigidbody> ().velocity = direction;
		//Invoke("SpawnBullet", Random.Range(1f, 10f));
		//waitTime = Mathf.Max(1, waitTime - 1);
		StartCoroutine("SpawnSimpleBullet");
	}

	public void DoSpawn() {
		StartCoroutine("SpawnBullet");

	}
}
