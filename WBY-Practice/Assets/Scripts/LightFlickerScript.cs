using UnityEngine;
using System.Collections;

public class LightFlickerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		light.intensity = Random.Range(0, 8);
	
	}
}
