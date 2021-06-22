using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour {

	private R_PlayerCtrl Rctrl;
	private Y_PlayerCtrl Yctrl;

	public GameObject WIN_R;
	public GameObject LOSE_R;

	public GameObject WIN_Y;
	public GameObject LOSE_Y;

	bool result = false;

	void Start () {
		Rctrl = GameObject.Find ("R_Player").GetComponent<R_PlayerCtrl> ();
		Yctrl = GameObject.Find ("Y_Player").GetComponent<Y_PlayerCtrl> ();
	}

	void Update () {
		if (Rctrl.hp <= 0 && result == false) {
			WIN_Y.SetActive (true);
			LOSE_R.SetActive (true);
			result = true;
		} else if (Yctrl.hp <= 0 && result == false) {
			WIN_R.SetActive (true);
			LOSE_Y.SetActive (true);
			result = true;
		}
	}
}
