using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Y_PlayerCtrl : MonoBehaviour {

	public Slider healthBarSlider;

	public int hp = 3;
	public GameObject fireEffect;
	private bool hitdelay_check = false;
	public SpriteRenderer rend;

	void Start () {
		rend = GetComponent<SpriteRenderer> ();
	}
	

	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.tag == "REDBULLET" || coll.gameObject.tag == "GREENBULLET") {
			if (hitdelay_check == false) {
				StartCoroutine ("blink");
				hp = hp - 1;
				healthBarSlider.value -= 1f;
				if (hp == 0) {
					CreatefireEffect (coll.transform.position);
					Destroy (this.gameObject);
				}
				Destroy (coll.gameObject);
				hitdelay ();
			}
		}
	}

	void CreatefireEffect(Vector3 pos){
		GameObject Effect1=(GameObject)Instantiate (fireEffect, pos, Quaternion.identity);
		Destroy (Effect1, 0.7f);
	}

	IEnumerator blink(){
		rend.enabled = false;
		yield return new WaitForSeconds (0.2f);
		rend.enabled = true;
		yield return new WaitForSeconds (0.2f);
		rend.enabled = false;
		yield return new WaitForSeconds (0.2f);
		rend.enabled = true;
		yield return new WaitForSeconds (0.2f);
		rend.enabled = false;
		yield return new WaitForSeconds (0.2f);
		rend.enabled = true;
	}

	void hitdelay(){
		hitdelay_check = true;
		StartCoroutine ("Hitdelay");
	}

	IEnumerator Hitdelay(){
		yield return new WaitForSeconds (2.0f);
		hitdelay_check = false;
	}
}
