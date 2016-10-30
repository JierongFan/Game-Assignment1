/*Student : Jierong Fan
 * Student ID: 100986919	
 * Date last Modified: 10/30/2016
 * */
using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

	private PlayerController player;

	//Check is in air or on ground
	void Start (){
		player = gameObject.GetComponentInParent<PlayerController>();
	}

	void OnTriggerEnter2D(Collider2D col){
		player.inAir = false;
	}

	void OnTriggerStay2D(Collider2D col){
		player.inAir = false;
	}

	void OnTriggerExit2D(Collider2D col){
		player.inAir = true;
	}
}
