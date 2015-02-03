using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FindAssignedPosition : MonoBehaviour {


	public Camera mainCam;

	// Use this for initialization
	void Start () {


		Debug.Log("this is the center position of panel 1: "+ this.transform.position);
		Debug.Log("trying to convert above position to screenSpace: "+mainCam.WorldToScreenPoint(this.transform.position));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
