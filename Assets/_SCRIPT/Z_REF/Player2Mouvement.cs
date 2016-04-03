using UnityEngine;
using System.Collections;

public class Player2Mouvement : MonoBehaviour {

	Rigidbody rb;
	public float vitesse = 900f;
	public float vitesseRotation = 900f;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent <Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.W)) {
			rb.AddForce (0, 0, vitesse * Time.deltaTime);
			
		}

		if (Input.GetKey(KeyCode.S)) {
			rb.AddForce(0, 0, -vitesse * Time.deltaTime);
		}
		
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce(vitesseRotation * Time.deltaTime,0,0);
		}
		
		if (Input.GetKey(KeyCode.A)) {
			rb.AddForce(-vitesseRotation * Time.deltaTime,0,0);
		}



	
	}


}
