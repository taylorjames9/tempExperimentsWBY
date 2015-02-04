using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class RandomSlide_PanelManager : MonoBehaviour {

	private float delayEnter;
	private  List<Transform> allTransformsOfArtInSequence; 
	private List<Vector2> allDestinations;

	// Use this for initialization
	void Start () {
		int i = 0;
		allTransformsOfArtInSequence = GameObject.Find("tempArtHolder").GetComponentsInChildren<Transform>().OfType<Transform>().ToList();
		Debug.Log ("Printout of alltransformsOfArt"+allTransformsOfArtInSequence);
		foreach(Transform art in allTransformsOfArtInSequence){
			//art.position = Vector2.Lerp(allTransformsOfArtInSequence[i].position, allDestinations[i].position, Time.time);
			art.gameObject.SetActive (false);
				//enderer.enabled = false;
			i++;
		}
	}

//	public IEnumerator moveToDesiredLocation(float delay){
//
//
//	}
}
