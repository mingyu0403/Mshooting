using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_PlayerMove : MonoBehaviour {

	public float moveSpeed = 10.0f;

	void Start () {
		
	}

	void Update () {

		KeyDown ();
		CheckOutbound ();

	}

	void KeyDown(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (new Vector3 (0, moveSpeed, 0) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector3 (moveSpeed, 0, 0) * Time.deltaTime);

		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (new Vector3 (0, -moveSpeed, 0) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector3 (-moveSpeed, 0, 0) * Time.deltaTime);
		}
	}

	void CheckOutbound(){
		Vector3 pos = Camera.main.WorldToViewportPoint (transform.position);
		if (pos.x < 0.05f) pos.x = 0.05f;
		if (pos.x > 0.85f) pos.x = 0.85f;
		if (pos.y < 0.70f) pos.y = 0.70f;
		if (pos.y > 0.95f) pos.y = 0.95f;
		transform.position = Camera.main.ViewportToWorldPoint (pos);
	}
}
