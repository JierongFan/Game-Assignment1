﻿/*Student : Jierong Fan
 * Student ID: 100986919	
 * Date last Modified: 10/30/2016
 * */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {


	[SerializeField]
	Text pointsLabel = null;
	[SerializeField]
	Text healthLabel = null;
	[SerializeField]
	Button restartBtn = null;
	[SerializeField]
	Text gameOverLabel = null;
	[SerializeField]
	GameObject player = null;

	//Update point and health
	public void UpdatePoints(){

		pointsLabel.text = "Points: " + Player.Instance.Points;

	}

	public void UpdateHealth(){

		healthLabel.text = "Health: " + Player.Instance.Health;
	}

	// Use this for initialization
	void Start () {
		Player.Instance.hud = this;
		RestartGame ();
	}

	// Update is called once per frame
	void Update () {

	}
		
	public void GameOver(){

		//hide labels with health and points
		pointsLabel.gameObject.SetActive(false);
		healthLabel.gameObject.SetActive(false);

		//deactive player
		player.SetActive(false);

		//display "Game Over" label
		gameOverLabel.gameObject.SetActive(true);


		//display "Restart" button
		restartBtn.gameObject.SetActive(true);

	}
		
	public void RestartGame(){

		//show labels with health and points
		pointsLabel.gameObject.SetActive(true);
		healthLabel.gameObject.SetActive(true);
		Player.Instance.Points = 0;
		Player.Instance.Health = 100;
		//activate player
		player.SetActive(true);

		//hide "Game Over" label
		gameOverLabel.gameObject.SetActive(false);

		//hide "Restart" button
		restartBtn.gameObject.SetActive(false);

	}
}
