using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToAnotherScene : MonoBehaviour {

	public bool isGallery = false;
	public bool isPortal_1 = false;
	public bool isPortal_2 = false;
	public bool isPortal_3 = false;
	public bool isPortal_4 = false;
	public bool isPortal_5 = false;
	public bool isPortal_6 = false;
	public bool isPortal_7 = false;
	public bool isPortal_8 = false;
	public bool isMain = false;

	// Use this for initialization
	void Start () {
		
	}

	void OnMouseEnter() {
		GetComponent<Renderer> ().material.color = Color.cyan;
	}

	void OnMouseExit() {
		GetComponent<Renderer> ().material.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {

		if (isPortal_1) {
			SceneManager.LoadScene ("Portal_1");
		} else if (isPortal_2) {
			SceneManager.LoadScene ("Portal_2");
		} else if (isPortal_3) {
			SceneManager.LoadScene ("Portal_3");
		} else if (isPortal_4) {
			SceneManager.LoadScene ("Portal_4");
		} else if (isPortal_5) {
			SceneManager.LoadScene ("Portal_5");
		} else if (isPortal_6) {
			SceneManager.LoadScene ("Portal_6");
		} else if (isPortal_7) {
			SceneManager.LoadScene ("Portal_7");
		} else if (isPortal_8) {
			SceneManager.LoadScene ("Portal_8");
		} else if (isGallery) {
			SceneManager.LoadScene ("Gallery");
		} else if (isMain) {
			SceneManager.LoadScene ("Main");
		}
	}
}
