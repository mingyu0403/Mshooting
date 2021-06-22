using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y_BulletFire : MonoBehaviour {

	public GameObject Bullet;
	public Transform bulletTr;

	private bool fire=false;
	private bool fire_v=false;
	Vector3 P_DIAMOND;
	Vector3 P_V;
	int fire_cnt=0;


	// 쿨타임
	float T_fire = 0.15f;
	float T_Vshot = 2.0f;

	float test = 0.0f;

	void Update () {
		test += Time.deltaTime;
		if(test > 0.2f){
			fire_cnt++;
			if (fire_cnt % 7 == 0) {
				DIAMONDshot ();
				fire_cnt = 0;
			} else {
				Instantiate (Bullet, bulletTr.position, bulletTr.rotation);
				test = 0;
			}
		}
		/*if (Input.GetKeyDown (KeyCode.G) && fire==false) {
			fire_cnt++;
			if (fire_cnt % 7 == 0) {
				DIAMONDshot ();
				fire_cnt = 0;
			}
			Instantiate (Bullet, bulletTr.position, bulletTr.rotation);
			fire = true;
			StartCoroutine ("delay_fire");
		}*/

		if (Input.GetKeyDown (KeyCode.H) && fire_v==false) {
			Vshot ();
			fire_v = true;
			StartCoroutine ("delay_v");
		}
	}

	IEnumerator delay_fire(){
		yield return new WaitForSeconds (T_fire);
		fire = false;
	}

	IEnumerator delay_v(){
		yield return new WaitForSeconds (T_Vshot);
		fire_v = false;
	}

	void DIAMONDshot(){
		/*     O
		 *    O O
		 *   O   O
		 */ 
		P_DIAMOND = bulletTr.position;
		StartCoroutine ("DIAMOND");
	}

	void Vshot(){
		/*    o        o
		 *     o      o
		 *      o    o
		 *       o  o
		 *        oo
		 */
		P_V = bulletTr.position;
		StartCoroutine ("V");
	}

	IEnumerator V(){
		Instantiate (Bullet, P_V, bulletTr.rotation * Quaternion.Euler(new Vector3(0,0,15)));
		Instantiate (Bullet, P_V, bulletTr.rotation * Quaternion.Euler(new Vector3(0,0,-15)));

		yield return new WaitForSeconds (0.2f);

		Instantiate (Bullet, P_V, bulletTr.rotation * Quaternion.Euler(new Vector3(0,0,15)));
		Instantiate (Bullet, P_V, bulletTr.rotation * Quaternion.Euler(new Vector3(0,0,-15)));

		yield return new WaitForSeconds (0.2f);

		Instantiate (Bullet, P_V, bulletTr.rotation * Quaternion.Euler(new Vector3(0,0,15)));
		Instantiate (Bullet, P_V, bulletTr.rotation * Quaternion.Euler(new Vector3(0,0,-15)));

		yield return new WaitForSeconds (0.2f);
	}

	IEnumerator DIAMOND(){
		Instantiate (Bullet, P_DIAMOND, bulletTr.rotation);

		yield return new WaitForSeconds (0.03f);

		Instantiate (Bullet, P_DIAMOND + (Vector3.left * 0.8f), bulletTr.rotation);
		Instantiate (Bullet, P_DIAMOND + (Vector3.right * 0.8f), bulletTr.rotation);

		yield return new WaitForSeconds (0.03f);

		Instantiate (Bullet, P_DIAMOND + (Vector3.left * 1.6f), bulletTr.rotation);
		Instantiate (Bullet, P_DIAMOND + (Vector3.right * 1.6f), bulletTr.rotation);
	}
		
}
