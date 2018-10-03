using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelChange : MonoBehaviour {

	public Animator animator;
	private int levelToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Invoke("fadeToLevel",0.1f);
	}

	public void fadeToLevel(int LevelIndex){
		levelToLoad = LevelIndex;
		animator.SetTrigger("fadeOut");
		
	}

	public void OnFadeComplete(){
		SceneManager.LoadScene(1);
	}
}
