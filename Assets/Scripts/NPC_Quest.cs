using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Quest : MonoBehaviour {
	public bool EndDialog;
	public GameObject Dialog1;
	public QuestEvent QE;
	public GameObject Dialog2;
	public bool finishDialog;
	public GameObject block;
	public GameObject npc;

	// Use this for initialization
	void Start () {
		if (Global.isOpen) {
			Destroy (block);
			Destroy (npc);
		}
	}

	// Update is called once per frame
	void Update () {
		if (QE.endQuest1 == true) {
			finishDialog = true;
		}
		if (EndDialog == true) {
			Time.timeScale = 1;
			QE.Quest1 = true;
			Dialog1.SetActive (false);
		}
		if (finishDialog == true) {
			Time.timeScale = 1;
			QE.Quest1 = false;
			Dialog1.SetActive (false);
			Destroy (block);
			Global.isOpen = true;
		}

	}

	void OnTriggerEnter (Collider col) {
		if (col.tag == "Player") {
			if (finishDialog == false) {
				Time.timeScale = 0;
				if (QE.endQuest1 == false) {
					Dialog1.SetActive (true);
				} else {
					Dialog2.SetActive (true);
				}
			} else {
					Dialog2.SetActive (true);
				}
			}
		}
	}
