using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelGui : MonoBehaviour {

	Text levelNum;

	void Awake(){
		DontDestroyOnLoad(transform.parent.gameObject);
	}

	void Start () {
		levelNum = GetComponent<Text>();
	}
	
	void Update(){
		//this needs to be done using properties
		levelNum.text = GameManager_Master.levelCounter.ToString();

	}


}
