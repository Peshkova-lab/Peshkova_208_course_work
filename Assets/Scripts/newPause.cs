using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class newPause : MonoBehaviour {

	bool paused = false;
	public GameObject pauseMenu; 
	public Button buttonGame;
	public Button buttonMenu;


	// Use this for initialization
	void Start () {
		paused = false;
		pauseMenu.gameObject.SetActive(false);
		buttonGame.onClick.AddListener (goToGame);
		buttonMenu.onClick.AddListener (goToMenu);

	}

	void goToGame() {
		Time.timeScale = 1;
		paused = false;
		pauseMenu.gameObject.SetActive (false);
	}

	void goToMenu() {
		SceneManager.LoadScene ("mainMenu");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			if (!paused) {
				Time.timeScale = 0;
				paused = true;
				pauseMenu.gameObject.SetActive(true);
			} else {
				Time.timeScale = 1;
				paused = false;
				pauseMenu.gameObject.SetActive(false);
			}
		
		}
		
	}



}

