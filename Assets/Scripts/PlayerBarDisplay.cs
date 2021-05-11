using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBarDisplay : MonoBehaviour {
	public GUISkin mySkin;
	public PlayerStat Char;
	public bool Visible = true;

	public GameObject info; 
	public GameObject pauseMenu; 

	// Use this for initialization
	void Start () {
		
	}

	void OnGUI () {
		if (Visible) {
			GUI.skin = mySkin;

			float MaxHealth = 200;
			float CurHealth = PlayerStat.curHP;
			float MaxMana = 200;
			float CurMana = PlayerStat.curMP;
			float needExp = 1000;
			float curExp = PlayerStat.curEXP;

			float HealthBarLen = CurHealth / MaxHealth;
			float ManaBarLen = CurMana / MaxMana;
			float ExpBarLen = curExp / needExp;

			GUI.Box (new Rect (10, 15, 254 * HealthBarLen, 15), " ", GUI.skin.GetStyle ("HPbar"));
			GUI.Box (new Rect (10, 30, 254 * ManaBarLen, 15), " ", GUI.skin.GetStyle ("MPbar"));
			GUI.Box (new Rect (10, 55, 254 * ExpBarLen, 15), " ", GUI.skin.GetStyle ("Expbar"));
			GUI.Box(new Rect(10, 10, 254, 64), " ", GUI.skin.GetStyle("PlayerBar"));
		}
	}
		
	// Update is called once per frame
	void Update () {
		if ((info.activeSelf) || (pauseMenu.activeSelf) || (Global.pictures == 3)) {
			Visible = false;
		} else {
			Visible = true;
		}
	}
}
