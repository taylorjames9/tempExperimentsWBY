using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager_Master : MonoBehaviour {


	//PseudoCode
	//When GameManager_Master (this) loads it tells the frameCountDownBar to go down. 
	//
	public static List<string> allLevelNames;
	public static int levelCounter;

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}

	// Use this for initialization
	public static void Start () {
		levelCounter = 0;
		Debug.Log (" Here is list of all level names");
		allLevelNames.Add("StoryScene_1");
		allLevelNames.Add("StoryScene_2");
		allLevelNames.Add("StoryScene_3");
		Debug.Log (allLevelNames.ToString());
	}
	
	public static void LoadNextLevel(){
		Application.LoadLevel(allLevelNames[levelCounter]);
		levelCounter++;
	}
}
