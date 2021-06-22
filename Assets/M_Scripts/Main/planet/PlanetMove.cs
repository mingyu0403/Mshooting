using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMove : MonoBehaviour {

	public float PlanetSpeed = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (PlanetSpeed, 0, 0) * Time.deltaTime);
		Destroy (this.gameObject, 5.0f);
	}
}
