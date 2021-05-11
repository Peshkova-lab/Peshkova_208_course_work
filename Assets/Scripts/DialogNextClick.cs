using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNextClick : MonoBehaviour {
	public GameObject Text1;
	public GameObject Text2;
	private bool isText1 = true;
	public NPC_Quest nps_questScript;
	public bool finishDialog;
	public GameObject objectQuest1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (isText1 == true) {
				isText1 = false;
			} else {
				if (finishDialog == false) {
					isText1 = true;
					objectQuest1.SetActive (true);
					nps_questScript.EndDialog = true;
				} else {
					isText1 = true;
					nps_questScript.finishDialog = true;
				}
			}
		}
		if (isText1 == true) {
			Text1.SetActive (true);
			Text2.SetActive (false);
		} else {
			Text1.SetActive (false);
			Text2.SetActive (true);
		}
	}
}
