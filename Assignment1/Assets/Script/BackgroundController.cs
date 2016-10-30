using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	[SerializeField]
	float speed = 0.5f;


	private Transform _transform = null;
	private Vector2 _currentPosition ;

	//Constants
	private const float startPos = 30.1f;
	private const float resetPos = -20.9f;

	// Use this for initialization
	void Start () {

		_transform = gameObject.transform;
		_currentPosition = _transform.position;

		//Reset the position
		Reset ();
	}

	// Update is called once per frame
	void Update () {

		//Scrolling backgriund
		_currentPosition = _transform.position;
		_currentPosition -= new Vector2 (speed,0);
		_transform.position = _currentPosition;

		if (gameObject.transform.position.x < resetPos)
			Reset ();
	}

	public void Reset(){

		//Reset backgorund
		_currentPosition = new Vector2 (startPos,0);
		_transform.position = _currentPosition;

	}
}
