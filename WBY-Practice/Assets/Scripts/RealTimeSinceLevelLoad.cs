using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RealTimeSinceLevelLoad : MonoBehaviour {

	Text realTime;
	
	void Awake(){
		//DontDestroyOnLoad(transform.parent.gameObject);
	}
	
	void Start () {
		realTime = GetComponent<Text>();
	}
	
	void Update(){
		//this needs to be done using properties
		realTime.text = Time.timeSinceLevelLoad.ToString();
		
	}

}
