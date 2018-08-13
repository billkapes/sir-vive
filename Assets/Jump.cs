using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Jump : MonoBehaviour {
	public Vector3 movement = Vector3.zero;

	Vector2 startPos;
	Vector2 direction;
	bool canMove;

	// Use this for initialization
	void Start () {
		canMove = true;
	}
	
	// Update is called once per frame
	void Update () {
		KeyboardMovement ();
		TouchMovement ();
		//DoMovement();
	}

	void DoMovement() {

		if (!canMove) {
			return;
		}
		canMove = false;
		if (movement != Vector3.zero) {
			if ((transform.position + movement).x > 4 || (transform.position + movement).x < -4) {
				movement = Vector3.zero;
				canMove = true;
				return;
			}
			if ((transform.position + movement).z > 4 || (transform.position + movement).z < -4) {
				movement = Vector3.zero;
				canMove = true;
				return;
			}
			transform.DOJump(transform.position + movement, 0.25f, 1, 0.1f, false).OnComplete(SetCanMoveTrue);
			movement = Vector3.zero;
		} 
	}

	void SetCanMoveTrue() {
		canMove = true;
	}
	void TouchMovement() {


	
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);

			// Handle finger movements based on TouchPhase
			switch (touch.phase)
			{
			//When a touch has first been detected, change the message and record the starting position
			case TouchPhase.Began:
				// Record initial touch position.
				startPos = touch.position;
				break;

				//Determine if the touch is a moving touch
			case TouchPhase.Moved:
				// Determine direction by comparing the current touch position with the initial one
				direction = touch.position - startPos;
				break;

			case TouchPhase.Ended:
				// Report that the touch has ended when it ends
				Debug.Log (direction.ToString ());
				if (Mathf.Abs (direction.x) > Mathf.Abs (direction.y)) {
					if (direction.x > 0f) {
						movement = Vector3.right * 2f;
					} else {
						movement = Vector3.left * 2f;
					}
				} else {
					if (direction.y > 0f) {
						movement = Vector3.forward * 2f;
					} else {
						movement = Vector3.back * 2f;
					}
				}
				DoMovement ();
				break;
			}
		}

	}

	void KeyboardMovement ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			movement = Vector3.right * 2f;
			DoMovement();
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			movement = Vector3.forward * 2f;
			DoMovement();
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			movement = Vector3.right * 2f;
			DoMovement();
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			movement = Vector3.back * 2f;
			DoMovement();
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			movement = Vector3.left * 2f;
			DoMovement();
		}
	}
}
