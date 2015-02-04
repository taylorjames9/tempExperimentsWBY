using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager_Master : MonoBehaviour {

	//singleton instanstiation
//	static GameManager_Master gm_instance;
//
//	public static GameManager_Master GM_Instance {
//		get {
//			if (gm_instance == null) {
//				gm_instance = FindObjectOfType<GameManager_Master> ();
//				if (gm_instance == null) {
//					GameObject obj = new GameObject ();
//					obj.hideFlags = HideFlags.HideAndDontSave;
//					gm_instance = obj.AddComponent<GameManager_Master> ();
//				}
//			}
//			return gm_instance;
//		}
//	}


	//

	public int levelCounter;
	List<string> allLevelNames;

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
		//allLevelNames = 
	}

	// Use this for initialization
	public void Start () {
		allLevelNames = new List<string>();
		levelCounter = 0;
		Debug.Log (" Here is list of all level names");
		//Debug.Log (allLevelNames.ToString());
		allLevelNames.Add("StoryScene_1");
		allLevelNames.Add("StoryScene_2");
		allLevelNames.Add("StoryScene_3");

	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(allLevelNames[levelCounter]);
		levelCounter++;
	}
}
