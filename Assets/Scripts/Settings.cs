using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour {
	
	public AudioMixer am;

	public void AudioVolume (float sl){
		am.SetFloat ("masterVolume", sl);
	}

	public void Quality (int q) {
		QualitySettings.SetQualityLevel(q);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
