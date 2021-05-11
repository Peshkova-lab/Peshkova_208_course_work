using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectQuest : MonoBehaviour {

	public QuestEvent QEvent;
	public GameObject Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnCollisionEnter (Collision variable) {
		if (variable.gameObject == Player) {
			QEvent.endQuest1 = true;
			Destroy (gameObject);
		}
	}

	}

