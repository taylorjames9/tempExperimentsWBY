using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KenBurns : MonoBehaviour {

	public Transform anchorPT;
	public float speed;

	void Start(){
		StartCoroutine(KenBurnsMethod (anchorPT, speed));
	}

	void Update() {

	}

	public IEnumerator KenBurnsMethod(Transform anchorPoint, float spd){
		while(anchorPoint !=null){
			float step = spd * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, anchorPoint.position, step);
			yield return 0;
		}
	}

//	public IEnumerator KenBurnsSequence(Transform[] anchorPoints, float spd){
//		while(anchorPoints !=null){
//			float step = spd * Time.deltaTime;
//			transform.position = Vector3.MoveTowards(transform.position, anchorPoint.position, step);
//			yield return 0;
//		}
//	}
}
