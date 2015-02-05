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

	/**These variables are static so that they can be used in the static method called 
	 * loadNextLevel() below. They are also static so that their values are not reset 
	 * with each new scene Load**/ 

	public static int levelCounter;
	public static List<string> allLevelNames;

	void Awake(){
		/**This ensures that each this gameManager persists from level to level**/
		DontDestroyOnLoad(transform.gameObject);
	}

	// Use this for initialization
	public void Start () {
		/**Adding each available scene name to the list of scene names**/
		allLevelNames = new List<string>();
		allLevelNames.Add("StoryScene_1");
		allLevelNames.Add("StoryScene_2");
		allLevelNames.Add("StoryScene_3");

		/**the level counter will be zero automatically, but I'm declaring a variable here
		 * in case it is useful to start play from another level. **/
		levelCounter = 0;

	}

	/**this is a static function so that it can be easily called from any other object or
	animation in the scene**/

	//This function ultimately needs to receive a parameter of class Transition
	public static void LoadNextLevel(){
		levelCounter++;
		Debug.Log ("LevelCounter = "+levelCounter);
		if(levelCounter < allLevelNames.Count){
			Application.LoadLevel(allLevelNames[levelCounter]);

		}
	}
}
