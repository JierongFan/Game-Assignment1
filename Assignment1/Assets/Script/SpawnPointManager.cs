using UnityEngine;
using System.Collections;

public class SpawnPointManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Random spawn point
	void Update () {
		float Rx = Random.Range (-3f, 10f);
		float Ry = Random.Range (6f, 6.5f);
		gameObject.transform.position = new Vector2 (Rx, Ry);

	}
}
