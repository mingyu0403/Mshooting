using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyanCtrl : MonoBehaviour {

	public float PlanetSpeed = 10.0f;
	
	public GameObject P_bullet;

	bool chk1 = false;
	bool chk2 = false;

	Vector3 pos;
	int i;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		move ();
		cyan_fire ();
	}

	void move(){
		transform.Translate (new Vector3 (PlanetSpeed, 0, 0) * Time.deltaTime);
		Destroy (this.gameObject, 5.0f);
	}

	void cyan_fire(){
		if (transform.localPosition.x >-1.0f && chk1 == false) {
			for (i = 0; i < 360; i += 40) {
				Instantiate (P_bullet, transform.position, Quaternion.Euler(new Vector3(0,0,i)));
			}
			 pos = transform.position;
			Invoke ("cyan_fire2",0.2f);
			chk1 = true;
		}
	}

	void cyan_fire2(){
		if (transform.localPosition.x >-1.0f && chk2 == false) {
			for (i = 0; i < 360; i += 40) {
				Instantiate (P_bullet, pos, Quaternion.Euler(new Vector3(0,0,i)));
			}
			chk2 = true;
		}
	}
}
