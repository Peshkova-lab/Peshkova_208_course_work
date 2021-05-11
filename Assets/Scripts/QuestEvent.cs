using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestEvent : MonoBehaviour {
	public bool Quest1 = false;
	public GameObject Text1;
	public bool endQuest1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (endQuest1 == false) {
			if (Quest1 == true) {
				Text1.SetActive (true);
			} else {
				Text1.SetActive (false);
			}
		} else {
			Text1.SetActive (false);
		}
	}
}
