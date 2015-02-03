using UnityEngine;
using System.Collections;

public class GoToAssignedPosition : MonoBehaviour {

	private Vector2 myStartPosition;
	private Vector2 myTargetPosition;
	public Transform myTarg;
	private float fracJourney;

	// Use this for initialization
	void Start () {

		fracJourney = 1.0f;
		myStartPosition = new Vector2(this.transform.position.x - Random.Range(-55,55), this.transform.position.y);
		myTargetPosition = GameObject.Find("TopLeft").transform.position;

		Debug.Log ("MyStartPositionIS "+myStartPosition);
		Debug.Log ("MyTargetPositionIS "+myTargetPosition);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = Vector3.Lerp(myStartPosition, myTarg.position, Time.time);
	}
}
