﻿using UnityEngine;
using System.Collections;

public class PicaScoreLevel3 : MonoBehaviour {

	public int count;
	
	// Use this for initialization
	void Start () {
		
		count = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}

		
		if (count == 5) {
			Application.LoadLevel ("Bravo");
			Cursor.visible = true;
			
		}
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		
		if (other.gameObject.CompareTag ("letter")) 
		{
			count += 1;
		}
	}
}
