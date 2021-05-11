using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInfo : MonoBehaviour {

	bool infoShow = false;
	public GameObject info; 
	public Button buttonInfo;

	// Use this for initialization
	void Start () {
		infoShow = false;
		info.gameObject.SetActive(false);
	}
		

	void information() {
		if (!infoShow) {
			info.gameObject.SetActive (true);
			Time.timeScale = 0;
			infoShow = true;
		} else {
			info.gameObject.SetActive (false);
			Time.timeScale = 1;
			infoShow = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		buttonInfo.onClick.AddListener (information);
	}
}
