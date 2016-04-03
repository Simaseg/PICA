using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {

	float temps;
	float energie = 100;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		//gameObject.SetActive (false);
		//rb.AddForce (0, 0, 500);
		//Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {
		print ("J'ai touché a " + col.transform.position);
		temps = Time.time;
	}

	void OnCollisionStay (Collision col) {
		print ("J'ai touché a " + col.gameObject.name);
		if (Time.time > temps + 5) {
			energie -= 2;
			temps = Time.time;
		}
	}

	void OnCollisionExit (Collision col) {
		print ("J'ai touché a " + col.gameObject.name);
	}

	void OnTriggerEnter(Collider tri) {
		Destroy (tri.gameObject);
	}

	void OnTriggerStay(Collider tri) {
	}

	void OnTriggerExit(Collider tri) {
	}
}






