﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		transform.Rotate (0,0,(100*Time.deltaTime));
	}
}
