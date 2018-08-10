using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject bulletPrefab;
	public Vector3 direction;


	public int waitTime;
	 
	// Use this for initialization
	void Start () {
		//Invoke("SpawnBullet", Random.Range(1f, 10f));
		waitTime = 25;
		//StartCoroutine("SpawnBullet");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnBullet() {
		//yield return new WaitForSeconds (Random.Range(1f, waitTime));
		GameObject bullet = Instantiate (bulletPrefab, transform.position, transform.rotation) as GameObject;	
		yield return new WaitForSeconds (1f);
		//bullet.GetComponent<Rigidbody> ().velocity = direction;
		//Invoke("SpawnBullet", Random.Range(1f, 10f));
		waitTime = Mathf.Max(1, waitTime - 1);
		//StartCoroutine("SpawnBullet");


	}

	public void DoSpawn() {
		StartCoroutine("SpawnBullet");

	}
}
