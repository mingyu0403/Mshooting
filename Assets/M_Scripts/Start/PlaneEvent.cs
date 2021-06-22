using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneEvent : MonoBehaviour {

	public GameObject R_plane;
	public GameObject Y_plane;

	public float speed = 500.0f;
	bool chk = false;

	void Start () {
		
	}

	void Update () {
		
		if (R_plane.transform.position.y >= 10) {
			PlaneEvent1 ();
		} else if (!chk) {
			R_plane.transform.Translate (0, 10 * Time.deltaTime, 0);
			Y_plane.transform.Translate (0, 10 * Time.deltaTime, 0);
		} else {
			if (R_plane.transform.position.y <= -2) {
				R_plane.transform.Translate (0, 10 * Time.deltaTime, 0);
				Y_plane.transform.Translate (0, 10 * Time.deltaTime, 0);
			}
		}
	}

	void PlaneEvent1(){
		R_plane.transform.localPosition = new Vector3(3f, -5.5f, 0f);
		R_plane.transform.localRotation = Quaternion.Euler (new Vector3(0f, 0f, 0f));
		Y_plane.transform.localPosition = new Vector3(-3f, -5.5f, 0f);
		Y_plane.transform.localRotation = Quaternion.Euler (new Vector3(0f, 0f, 0f));
		chk = true;
	}
}
