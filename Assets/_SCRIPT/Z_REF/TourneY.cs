using UnityEngine;
using System.Collections;

public class TourneY : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Input.GetAxis ("Mouse Y"), 0, 0);
	}
}
