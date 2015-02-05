using UnityEngine;
using System.Collections;

public class Light_Tricks : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(lightFlickr());
	}


	public IEnumerator lightFlickr( ){
		while(true){
			light.intensity = Random.Range(0, 3);
			yield return new WaitForSeconds(1.0f);
		}
	}
}
