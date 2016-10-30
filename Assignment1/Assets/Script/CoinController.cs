using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {
	[SerializeField]
	private float speed = 0.5f;

	public AudioClip clip;

	private Transform _transform;
	private Vector2 _currentPosistion;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosistion = _transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		_currentPosistion = _transform.position;

		_currentPosistion -= new Vector2 (speed, 0f);
		_transform.position = _currentPosistion;
	}

	public void OnTriggerEnter2D(Collider2D col2d){
		AudioSource.PlayClipAtPoint (clip, _currentPosistion,1);
		Destroy (gameObject);
	}
}
