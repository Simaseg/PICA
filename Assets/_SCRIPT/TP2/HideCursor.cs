﻿using UnityEngine;
using System.Collections;

public class HideCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {

 		Cursor.visible = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey("escape"))
			Application.Quit();
	}
}
