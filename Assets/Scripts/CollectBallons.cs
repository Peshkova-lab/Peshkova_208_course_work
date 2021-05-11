using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectBallons : MonoBehaviour {

	public GameObject finishHouse;
	public GameObject Player;
	static int inp=0;
	public Image im1; 
	public Image im2; 
	public Image im3; 
	public Image im4; 
	public Image im5; 
	public Image im6; 
	public Image im7; 
	public Image im8; 
	public Image im9; 
	public Image im10; 


	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
	}

	void OnCollisionEnter (Collision variable) {
		if (variable.gameObject == Player) {
			PlayerStat.curEXP += 100;
			inp += 1;
			if (inp == 1)
				im1.gameObject.SetActive (true);
			if (inp == 2)
				im2.gameObject.SetActive (true);
			if (inp == 3)
				im3.gameObject.SetActive (true);
			if (inp == 4)
				im4.gameObject.SetActive (true);
			if (inp == 5)
				im5.gameObject.SetActive (true);
			if (inp == 6)
				im6.gameObject.SetActive (true);
			if (inp == 7)
				im7.gameObject.SetActive (true);
			if (inp == 8)
				im8.gameObject.SetActive (true);
			if (inp == 9)
				im9.gameObject.SetActive (true);
			if (inp == 10) {
				im10.gameObject.SetActive (true);
				finishHouse.gameObject.SetActive (true);
			}
			Destroy (gameObject);

		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
