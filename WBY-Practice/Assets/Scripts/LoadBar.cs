using UnityEngine;
using System.Collections;

public class LoadBar : MonoBehaviour {


	/****PseudoCode
	At the start of the scene, the loading bar triggers a function called reduce loading bar over time.
	This function takes two PUBLIC parameters...one that allows you two set a delay...and the other that says how much time it should take the loading bar to reduce to zero. 
	When the loading bar finishes counting down...we tell the GameManager. (Probably a static variable on GM that says 
	Scene counter USE PROPERTIES...ie...anytime this variable changes...trigger a new scene to load. 
	****/

	public float delayToStart;
	public float timeToFinish;

	private Transform myLoadingBar; 
	private GameObject gm_Master;
	private GameManager_Master gm_Master_Script;
	
	// Use this for initialization
	void Start () {
		myLoadingBar = GameObject.Find ("LoadingBar").transform;
		StartCoroutine(reduceLoadingBarOverTime(0, 10f));
		gm_Master = GameObject.Find("GameManager_Master");
		gm_Master_Script = gm_Master.GetComponent<GameManager_Master>();
	}

	public IEnumerator reduceLoadingBarOverTime(float delayStart, float timeFinish){
		float timeElapse; 
		float barSizeX; 

		timeElapse = timeFinish;

		while(timeElapse >= 0){
			timeElapse = timeFinish - Time.timeSinceLevelLoad;
			barSizeX = myLoadingBar.localScale.x;

			barSizeX = timeElapse;
			myLoadingBar.localScale = new Vector2(barSizeX, myLoadingBar.localScale.y);
			yield return 0;
		}
		GameManager_Master.LoadNextLevel();
		myLoadingBar.gameObject.SetActive(false);
	}
}
