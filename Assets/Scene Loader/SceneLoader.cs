using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour {

	private static SceneLoader instance;
	private static bool shouldPlayOpeningAnimation = false;

	public Text LoadingPercentage;
	public Image LoadingProgressBar;

	private AsyncOperation loadingSceneOperation;
	private Animator componentAnimator;


	public static void SwitchToScene(string sceneName){
		instance.componentAnimator.SetTrigger("sceneStart");

		instance.loadingSceneOperation = SceneManager.LoadSceneAsync(sceneName);
		instance.loadingSceneOperation.allowSceneActivation = false;
	}
	// Use this for initialization
	void Start () {

		instance = this;

		componentAnimator = GetComponent<Animator> ();
		if (shouldPlayOpeningAnimation)
			componentAnimator.SetTrigger ("sceneStart");
	}
	
	// Update is called once per frame
	void Update () {
		if (loadingSceneOperation != null) {
			LoadingPercentage.text = Mathf.RoundToInt (loadingSceneOperation.progress * 100) + "%";
			LoadingProgressBar.fillAmount = loadingSceneOperation.progress;
		}
	}


	public void OnAnimationOver() {
		
	}
}
