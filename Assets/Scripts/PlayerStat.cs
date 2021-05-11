using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStat : MonoBehaviour {

	public static bool death;
	int showstat = 0;

	public static float curHP = 200;
	public static float curMP = 200;
	public static float curEXP = 1000;

	public static int lvl = 1;

	public static void lvlUP() {
		lvl += 1;
		PlayerBehaviour.c_speed += 3;
		PlayerBehaviour.c_jump += 2;
		curHP += 200;
		curMP += 200;
	}

	// Use this for initialization
	void Start () {
		death = false;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (curHP > 200) {
			curHP = 200;
		}
		if (curHP <= 0) {
			curHP = 0;
			death = true;
			Time.timeScale = 0;
		}
		if (curMP < 0) {
			curMP = 0;
		}
		if (curMP > 200) {
			curMP = 200;
		}
		if (showstat == 0) {
			if (Input.GetKeyDown (KeyCode.P)) {
				showstat = 1;
			}
		} else if (showstat == 1) {
			if (Input.GetKeyDown (KeyCode.P)) {
				showstat = 0;
			}
		}

		if (curEXP >= 1000) {
			lvlUP();
			curEXP = curEXP-1000;
		}
	}

	void OnGUI() {
		if (showstat == 1) {
			GUI.Box (new Rect (10, 70, 250, 150), "stats");
			GUI.Label (new Rect (10, 95, 300, 300), "LvL: " + lvl);
			GUI.Label (new Rect (10, 110, 300, 300), "hp: " + curHP);
			GUI.Label (new Rect (10, 125, 300, 300), "mp: " + curMP);
			GUI.Label (new Rect (10, 140, 300, 300), "exp: " + curEXP);
			GUI.Label (new Rect (10, 155, 300, 300), "speed: " + PlayerBehaviour.c_speed);
			GUI.Label (new Rect (10, 170, 300, 300), "jump: " + PlayerBehaviour.c_jump);

		}
					else if (showstat == 0) {
						useGUILayout = false;
					}
					if (death == true) {
			if (GUI.Button (new Rect(Screen.width/2, Screen.height/2, 100, 50), "Переграти")) {
				curHP = 200;
				SceneManager.LoadScene(1);
			}
		}
	}

}
