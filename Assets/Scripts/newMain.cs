using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class newMain : MonoBehaviour {

	public AudioSource btn_click_sound;
	public bool activeMenu;
	public Button buttonGame;
	public Button buttonExit;


	void Start () {
		buttonGame.onClick.AddListener (goToGame);
		buttonExit.onClick.AddListener (goToExit);

	}

	void goToGame() {
		btn_click_sound.Play ();
		SceneManager.LoadScene ("main");
	}
		

	void goToExit() {
		btn_click_sound.Play ();
		Application.Quit();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
