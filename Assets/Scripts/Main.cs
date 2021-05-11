using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	public GameObject picture_1;
	public GameObject picture_2;
	public GameObject picture_3;
	public GameObject picture_4;
	public GameObject picture_5;
	public GameObject picture_6;
	public GameObject picture_7;
	public GameObject picture_8;


	// Use this for initialization
	void Start () {
		picture_2.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_2 = false;
		picture_3.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_3 = false;
		picture_1.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_1 = false;
		picture_4.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_4 = false;
		picture_5.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_5 = false;
		picture_6.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_6 = false;
		picture_7.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_7 = false;
		picture_8.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_8 = false;
		if (Global.pictures == 0) {
			picture_1.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_1 = true;
		}
		if (Global.pictures == 1) {
			picture_2.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_2 = true;
		}
		if (Global.pictures == 2) {
			picture_3.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_3 = true;
		}
		if (Global.pictures == 3) {
			picture_4.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_4 = true;
		}
		if (Global.pictures == 4) {
			picture_5.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_5 = true;
		}
		if (Global.pictures == 5) {
			picture_6.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_6 = true;
		}
		if (Global.pictures == 6) {
			picture_7.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_7 = true;
		}
		if (Global.pictures == 7) {
			picture_8.gameObject.GetComponent<MoveToAnotherScene> ().isPortal_8 = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
