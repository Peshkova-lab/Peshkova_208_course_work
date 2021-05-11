using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gallery : MonoBehaviour {

	public static bool picture;
	public GameObject finishGame;
	public GameObject but;
	public GameObject door;
	public GameObject picture_1;
	public GameObject picture_2;
	public GameObject picture_3;
	public GameObject molbert_1;
	public GameObject molbert_2;
	public GameObject molbert_3;
	public GameObject molbert_4;
	public GameObject molbert_5;
	public GameObject molbert_6;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Global.pictures >= 1) {
			picture_1.gameObject.SetActive (true);
		}
		if (Global.pictures >= 2) {
			picture_2.gameObject.SetActive (true);
		}
		if (Global.pictures >= 3) {
			Global.molberts = 6;
			picture_3.gameObject.SetActive (true);
			finishGame.gameObject.SetActive (true);
			but.gameObject.SetActive (false);
			door.gameObject.SetActive (false);
		}
		if (Global.molberts >= 1) {
			molbert_1.gameObject.SetActive (true);
		}
		if (Global.molberts >= 2) {
			molbert_2.gameObject.SetActive (true);
		}
		if (Global.molberts >= 3) {
			molbert_3.gameObject.SetActive (true);

		}
		if (Global.molberts >= 4) {
			molbert_4.gameObject.SetActive (true);
		}
		if (Global.molberts >= 5) {
			molbert_5.gameObject.SetActive (true);
		}
		if (Global.molberts >= 6) {
			molbert_6.gameObject.SetActive (true);
		}

			
	}
}
