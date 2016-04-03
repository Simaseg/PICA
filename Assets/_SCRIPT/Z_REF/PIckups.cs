using UnityEngine;
using System.Collections;

public class PIckups : MonoBehaviour {

	MeshRenderer mr;
	CapsuleCollider cc;
	float starter;
	bool timerStart = false ;

	// Use this for initialization
	void Start () {

		mr = GetComponent <MeshRenderer> ();
		cc = GetComponent <CapsuleCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (new Vector3 (300, 40, 5) * Time.deltaTime);



		if (cc.enabled == false) {

			if (timerStart == false) {

				timerStart = true;
				starter = Time.time;


			}
			else {
			
				if (Time.time >= (starter + 10)) {
					cc.enabled = true ;
					mr.enabled = true;
					timerStart = false;
				}
			}
	}
}
}
