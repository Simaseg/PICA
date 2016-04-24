using UnityEngine;
using System.Collections;

public class retour : MonoBehaviour {

	// Use this for initialization
	void Start () {

		
		if (Input.GetKey ("escape"))
			Application.LoadLevel("MENU_main");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
