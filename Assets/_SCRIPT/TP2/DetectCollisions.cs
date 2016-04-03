using UnityEngine;
using System.Collections;

public class DetectCollisions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y <= -2) {
			transform.position = new Vector3 (-61,25,-2);
		}
	
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		//print ("Ouch!" + hit.gameObject);
	}
}
