using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour {

	public GameObject Text1;
	public GameObject Text2;
	public GameObject Text3;
	public GameObject Text4;
	private bool isText1 = true;
	private bool isText2 = false;
	private bool isText3 = false;
	private bool isText4 = false;
	public GameObject DialogText;
	public GameObject Player;
	public GameObject npc;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		if (Global.isRead)
			Destroy (npc);
	}

	void OnCollisionEnter (Collision variable) {
		if (variable.gameObject == Player) {
			Time.timeScale = 0;
			DialogText.SetActive (true);
			Text1.SetActive (true);
			isText1 = true;
		}
	}
		
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (isText1) {
				isText1 = false;
				isText2 = true;
				isText3 = false;
				isText4 = false;
			} else if (isText2) {
				isText1 = false;
				isText2 = false;
				isText3 = true;
				isText4 = false;
			} else if (isText3) {
				isText1 = false;
				isText2 = false;
				isText3 = false;
				isText4 = true;
			} else if (isText4) {
				isText1 = false;
				isText2 = false;
				isText3 = false;
				isText4 = false;
				Global.isRead = true;
			}

			}

		if (isText1) {
			Text1.SetActive (true);
			Text2.SetActive (false);
			Text3.SetActive (false);
			Text4.SetActive (false);
		} else if (isText2) {
			Text1.SetActive (false);
			Text2.SetActive (true);
			Text3.SetActive (false);
			Text4.SetActive (false);
		} else if (isText3) {
			Text1.SetActive (false);
			Text2.SetActive (false);
			Text3.SetActive (true);
			Text4.SetActive (false);
		} else if (isText4) {
			Text1.SetActive (false);
			Text2.SetActive (false);
			Text3.SetActive (false);
			Text4.SetActive (true);
		} else if (!isText4) {
			DialogText.SetActive (false);
			Time.timeScale = 1;

		}
	}
}
