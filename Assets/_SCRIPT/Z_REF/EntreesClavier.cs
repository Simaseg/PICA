using UnityEngine;
using System.Collections;

public class EntreesClavier : MonoBehaviour {
	public float vitesse = 2f;
	public float vitesseRotation = 2f;
	// Use this for initialization
	void Start () {
	



	}
	
	// Update is called once per frame
	void Update () {


//		if (Input.GetKeyDown (KeyCode.Space)) {
//			print ("Tu a appuyé sur espace!!");
//		}
//
//		if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.A)) {
//			print ("Tu maintiens espace!!");
//			transform.Rotate(0, 0.3f, 0);
//		}
//
//		if (Input.GetKeyUp (KeyCode.Space)) {
//			print ("Tu a relaché espace!!");
//		}

//		if (Input.GetKey (KeyCode.UpArrow)) {
//			transform.Translate (0, 0, vitesse * Time.deltaTime);
//		}
//		if (Input.GetKey (KeyCode.DownArrow)) {
//			transform.Translate (0, 0, -vitesse * Time.deltaTime);
//		}
//
//		if (Input.GetKey (KeyCode.RightArrow)) {
//			transform.Rotate(0, vitesseRotation * Time.deltaTime,0);;
//		}
//		if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKey (KeyCode.LeftAlt)) {
//			transform.Translate (-vitesse * Time.deltaTime, 0, 0);


//		} else if (Input.GetKey (KeyCode.LeftArrow)) {
//			transform.Rotate(0, -vitesseRotation * Time.deltaTime,0);
//		}

		//print (Input.GetAxis("Mouse X"));
		//transform.position = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
		transform.Translate (Input.GetAxis ("Horizontal")* Time.deltaTime * vitesse, 0, Input.GetAxis ("Vertical")* Time.deltaTime * vitesse);
		transform.Rotate (0, Input.GetAxis ("Mouse X"), 0);

		if (Input.GetButton ("Fire1")) {
			print ("PewPewww!!!!!!!!!!!!!!!");
		}
	}
}








