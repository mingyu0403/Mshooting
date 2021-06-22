using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMove : MonoBehaviour {

	public float moveSpeed = 10;

	GameObject Y_Player;

	void start(){
		Y_Player = GameObject.Find ("Y_Player");
	}

	public void Up(){
		Y_Player.transform.Translate (new Vector3 (-(moveSpeed * Time.deltaTime * Time.timeScale), 0, 0));
	}
	public void Right(){
		Y_Player.transform.Translate (new Vector3 (moveSpeed, 0, 0) * Time.deltaTime);
	}
	public void Down(){
		Y_Player.transform.Translate (new Vector3 (0, -moveSpeed, 0) * Time.deltaTime);
	}
	public void Left(){
		Y_Player.transform.Translate (new Vector3 (0, (moveSpeed * Time.deltaTime * Time.timeScale), 0));
	}
}
