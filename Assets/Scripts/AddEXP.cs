using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEXP : MonoBehaviour {
	
	public GameObject Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
	}

	void OnCollisionEnter (Collision variable) {
		if (variable.gameObject == Player) {
			PlayerStat.curEXP += 100;
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
