/*Student : Jierong Fan
 * Student ID: 100986919	
 * Date last Modified: 10/30/2016
 * */
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveForce = 65f;
	public float maxSpeed = 3;
	public float jumpForce = 700f;


	public bool inAir = false;

	private Rigidbody2D rb2d;
	private Animator anime;

	void Start(){
		rb2d = gameObject.GetComponent<Rigidbody2D>();
		anime = gameObject.GetComponent<Animator>();
	}

	void Update(){
		anime.SetBool ("inair",inAir); //inair animetion check 
		anime.SetFloat ("speed", Mathf.Abs (Input.GetAxis ("Horizontal")));
		//Character movement
		if (Input.GetAxis ("Horizontal") < -0.1f) {
			transform.localScale = new Vector3 (-8, 8, 1);
		}
		if (Input.GetAxis ("Horizontal") > 0.1f) {
			transform.localScale = new Vector3 (8, 8, 1);
		}
		//Disable double jump
		if (Input.GetButtonDown ("Jump")&& inAir == false) {
			rb2d.AddForce (Vector2.up * jumpForce);
		}
	}

	void FixedUpdate(){
		//Moving the player
		float h = Input.GetAxis ("Horizontal");

		//Limiting the sppeed of the player
		rb2d.AddForce (Vector2.right * moveForce * h);
		if (rb2d.velocity.x > maxSpeed) {
			rb2d.velocity = new Vector2 (maxSpeed, rb2d.velocity.y);
		}
		if (rb2d.velocity.x < -maxSpeed) {
			rb2d.velocity = new Vector2 (-maxSpeed, rb2d.velocity.y);
		}


	}

	void OnTriggerEnter2D(Collider2D cl2d){
		//Get point when collect coin
		if (cl2d.gameObject.tag == "coin") {
			Player.Instance.Points++;
		//Lose 10hp when hit by bomber 
		} else if(cl2d.gameObject.tag == "Enemy") {
			Player.Instance.Health -= 10;
			Debug.Log ("h-10");
		}
	}






}