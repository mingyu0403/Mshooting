using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRespon : MonoBehaviour {

	public GameObject[] Planet;
	public Transform PlanetResponTr;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("PlanetInstantiate", 3.0f, 6.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PlanetInstantiate(){
		//Instantiate (Planet [Random.Range(0,3)],PlanetResponTr.position,PlanetResponTr.rotation);
		Instantiate (Planet [0],PlanetResponTr.position,PlanetResponTr.rotation);
	}
}
