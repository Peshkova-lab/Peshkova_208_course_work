using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public Transform player;
	public GameObject Player;
	public float move_speed;
	public float rotation_speed;
	public Transform enemy;
	public int jump = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var look_dir = player.position - enemy.position;
		look_dir.y = 0;
		enemy.rotation = Quaternion.Slerp(enemy.rotation, Quaternion.LookRotation(look_dir), rotation_speed*Time.deltaTime);
		enemy.position += enemy.forward * move_speed * Time.deltaTime;
		enemy.transform.position += player.transform.up * jump * Time.deltaTime;
	}

	void OnCollisionEnter (Collision variable) {
		if (variable.gameObject == Player) {
			PlayerStat.curHP -= 10;
		}
	}
}
