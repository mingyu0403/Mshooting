using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandCtrl : MonoBehaviour {

	public float PlanetSpeed = 10.0f;

	public GameObject P_bullet;

	bool chk = false;

	int i;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		move ();
		sand_fire ();
	}

	void move(){
		transform.Translate (new Vector3 (PlanetSpeed, 0, 0) * Time.deltaTime);
		Destroy (this.gameObject, 5.0f);
	}

	void sand_fire(){
		
		if (transform.localPosition.x >-1.0f && chk == false) {
			for (i = Random.Range(0,10); i < 360; i += 30) {
				Instantiate (P_bullet, transform.position, Quaternion.Euler(new Vector3(0,0,i)));
			}
			chk = true;
		}
	}
}
