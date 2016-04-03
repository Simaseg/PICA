using UnityEngine;
using System.Collections;

public class SphereMouvement2 : MonoBehaviour {


	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		print (transform.position);

		if (transform.position.y < -3) {
			transform.position = new Vector3 (0,10,0);
			rb.velocity = new Vector3 (0,0,0);
			rb.angularVelocity = new Vector3 (0,0,0) ;
		}

	rb.AddForce (Input.GetAxis ("Horizontal")* 20, 0, Input.GetAxis ("Vertical")* 20);

	}
	
//
//	void OnCollisionEnter (Collision col) {
//		if (col.gameObject.tag.Equals("Ennemy")) {
//			Destroy (col.gameObject);
//		}
	void OnCollisionEnter (Collision col) {
		
		if (col.gameObject.tag.Equals ("Ennemy")){
			Destroy (col.gameObject);
		}

	
	}



}

