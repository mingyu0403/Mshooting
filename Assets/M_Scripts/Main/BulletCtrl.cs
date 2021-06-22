using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour {

	// bullet shot

	public float speed = 5;

	void Start () {
		
	}

	void Update () {
		transform.Translate (new Vector3 (0, speed, 0) * Time.deltaTime);	
	}

	void OnBecameInvisible(){
		Destroy (this.gameObject);
	}
}
