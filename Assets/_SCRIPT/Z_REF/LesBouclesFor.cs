using UnityEngine;
using System.Collections;

public class LesBouclesFor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				print (" la valeur de i est : " + i + " et j est : " + j);
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
