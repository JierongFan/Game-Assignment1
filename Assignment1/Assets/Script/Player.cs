/*Student : Jierong Fan
 * Student ID: 100986919	
 * Date last Modified: 10/30/2016
 * */
using UnityEngine;
using System.Collections;

public class Player {

	// Use this for initialization
	private static Player _instance = null;

	private Player(){
		
	}

	public static Player Instance{

		get{ 
			if (_instance == null) {
				_instance = new Player ();
			}

			return _instance;
		}
	}

	public HUDController hud = null;
	private int _points = 0;
	public int Points{
		get{ 
			return _points;
		}

		set{ 
			_points = value;
			hud.UpdatePoints ();
		}
	}

	private int _health = 100;
	public int Health{
		get{ 
			return _health;
		}

		set{ 
			_health = value;
			hud.UpdateHealth ();
			//When health = 0,  game over
			if (_health <= 0) {
				hud.GameOver ();
			}
		}
	}
}
