using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyBarrier : MonoBehaviour {
	public GameObject Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
	}

	void OnCollisionEnter (Collision variable) {
		if (variable.gameObject == Player) {
			PlayerStat.curHP = -1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
