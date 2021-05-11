using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddHP : MonoBehaviour {
	
	public GameObject Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
	}

	void OnCollisionEnter (Collision variable) {
		if (variable.gameObject == Player) {
			PlayerStat.curHP -= 10;
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
}
