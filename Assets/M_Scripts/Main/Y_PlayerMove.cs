using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y_PlayerMove : MonoBehaviour {

	public float moveSpeed = 10.0f;

	void Start () {

	}

	void Update () {

		KeyDown ();
		CheckOutbound ();

	}
		
	void KeyDown(){
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (new Vector3 (0, (moveSpeed * Time.deltaTime * Time.timeScale), 0));
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (new Vector3 ((moveSpeed * Time.deltaTime * Time.timeScale), 0, 0));

		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (new Vector3 (0, -(moveSpeed * Time.deltaTime * Time.timeScale), 0));
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (new Vector3 (-(moveSpeed * Time.deltaTime * Time.timeScale), 0, 0));
		}
	}

	void CheckOutbound (){
		Vector3 pos = Camera.main.WorldToViewportPoint (transform.position);
		if (pos.x < 0.05f) pos.x = 0.05f;
		if (pos.x > 0.85f) pos.x = 0.85f;
		if (pos.y < 0.05f) pos.y = 0.05f;
		if (pos.y > 0.30f) pos.y = 0.30f;
		transform.position = Camera.main.ViewportToWorldPoint (pos);
	}
}
