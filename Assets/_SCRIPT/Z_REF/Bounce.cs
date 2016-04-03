using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < -3) {
			transform.position = new Vector3 (0, 1, 0);
			rb.velocity = new Vector3 (0, 0, 0);
			rb.angularVelocity = new Vector3 (0, 0, 0);

		}
}
}