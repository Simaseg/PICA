using UnityEngine;
using System.Collections;

public class PlayerMouvment : MonoBehaviour {

	Rigidbody rb;
	public float vitesse = 900f;
	public float vitesseRotation = 900f;


	// Use this for initialization
	void Start () {

		rb = GetComponent <Rigidbody> ();


	}



	// Update is called once per frame
	void Update () {
	
		//rb.AddForce (Input.GetAxis ("Horizontal") * 20, 0, Input.GetAxis ("Vertical") * 20);



		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddForce (0, 0, vitesse * Time.deltaTime);

		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			rb.AddForce (0, 0, -vitesse * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddForce (vitesseRotation * Time.deltaTime, 0, 0);
		}


		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddForce (-vitesseRotation * Time.deltaTime, 0, 0);
		}

	


	}
		
	
}
