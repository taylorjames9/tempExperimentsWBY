using UnityEngine;
using System.Collections;

public class LoadBar : MonoBehaviour {


	/**PseudoCode
	At the start of the scene, the loading bar triggers a function called reduce loading bar over time.
	**/

	public float delayToStart = 0f;
	public float timeToFinish = 10f;
	public float standardLoadingBarSize = 10f;

	//private Transform myLoadingBar; 
	//private GameObject gm_Master;
	//private GameManager_Master gm_Master_Script;
	
	// Use this for initialization
	void Start () {
		timeToFinish = 10f;;
		Debug.Log ("Started a new script");
		Debug.Log ("New Time to finish this scene: "+timeToFinish);

		//myLoadingBar = GameObject.Find ("LoadingBar").transform;
		StartCoroutine(reduceLoadingBarOverTime(delayToStart, timeToFinish));
		//StopCoroutine("redu
		//gm_Master = GameObject.Find("GameManager_Master");
		//gm_Master_Script = gm_Master.GetComponent<GameManager_Master>();
	}

	/**This function takes two PUBLIC parameters: 
	1.) float delay allows you two set a delay and 
	2.) timeToFinish specifies how much time it should take the loading bar to reduce to zero. 
	When the loading bar finishes counting down...we tell the GameManager. (Probably a static variable on GM that says 
	Scene counter USE PROPERTIES...ie...anytime this variable changes...trigger a new scene to load
	 **/

	public IEnumerator reduceLoadingBarOverTime(float delayStart, float timeFinish){
		
		yield return new WaitForSeconds(delayStart);

		float newBarSizeX = standardLoadingBarSize; 
		float changePerSec = standardLoadingBarSize/timeFinish;

		while(Time.timeSinceLevelLoad - delayStart < timeFinish){

			newBarSizeX -= changePerSec / 60f;
			transform.localScale = new Vector2(newBarSizeX, transform.localScale.y);
			yield return 0;
		}

		GameManager_Master.LoadNextLevel();
		gameObject.SetActive(false);
	}
}
