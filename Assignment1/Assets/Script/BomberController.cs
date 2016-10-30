/*Student : Jierong Fan
 * Student ID: 100986919	
 * Date last Modified: 10/30/2016
 * */
using UnityEngine;
using System.Collections;

public class BomberController : MonoBehaviour {
	
	[SerializeField]
	GameObject explosion = null;

	private Vector2 _currentPosition;
	private Transform _transform = null;
	private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		_transform = rigid.transform;
		_currentPosition = _transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		
	}


	public void OnTriggerEnter2D(Collider2D col2d){
		//Show explosion animetion and destroy object
		_currentPosition = rigid.position;
		GameObject explode = Instantiate (explosion);
		explode.transform.position = _currentPosition + new Vector2(0f, 3f);
		Destroy (gameObject);
	}


}
