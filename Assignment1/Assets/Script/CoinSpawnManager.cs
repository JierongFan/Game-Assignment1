using UnityEngine;
using System.Collections;

public class CoinSpawnManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float Rx = Random.Range (14f, 20f);
		float Ry = Random.Range (0f, 4f);
		gameObject.transform.position = new Vector2 (Rx, Ry);
	}
}
