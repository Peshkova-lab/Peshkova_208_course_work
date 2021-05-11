using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

	public AudioSource jump_sound;
	public GameObject player;
	public int rotation = 250;
	public int speed = 6;
	public static int c_speed;
	public static int c_jump;
	public int jump = 3;

	public static float x = 0.0f;

	void Start () {
		c_speed = speed;
	}

	void Update(){
		if (Input.GetKey (KeyCode.W)) {
			player.transform.position += player.transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {
			speed = c_speed / 2;
			player.transform.position -= player.transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKeyUp (KeyCode.S)) {
			speed = c_speed * 2;
		}
		if (Input.GetKey (KeyCode.A)) {
			player.transform.position -= player.transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D)) {
			player.transform.position += player.transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.Space)) {
			jump_sound.Play ();
			player.transform.position += player.transform.up * jump * Time.deltaTime;
		}
			
		if (Input.GetKey (KeyCode.LeftShift)) {
			speed = c_speed*2;
		}
		
		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			speed = c_speed;
		}

		Quaternion rotate = Quaternion.Euler (0, x, 0);
		player.transform.rotation = rotate;

	}
		
}