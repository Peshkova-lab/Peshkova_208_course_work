using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");
	}

	void OnCollisionEnter (Collision variable) {
		if (variable.gameObject == Player) {
			Global.pictures += 1;
			SceneManager.LoadScene("Gallery");	
			Destroy (gameObject);
		}
	}
		
	
	// Update is called once per frame
	void Update () {
	}
}
