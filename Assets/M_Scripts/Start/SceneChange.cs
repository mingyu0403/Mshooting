﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	public string nextSceneName;

	void Start () {

	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			SceneManager.LoadScene (nextSceneName);
		}
	}

}
