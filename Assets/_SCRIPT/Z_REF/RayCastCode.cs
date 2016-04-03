using UnityEngine;
using System.Collections;

public class RayCastCode : MonoBehaviour {

	private RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Physics.Raycast (transform.position, transform.forward, out hit, 10)) {
			print ("Le raycast touche a de quoi." + hit.transform.name);
			if (Input.GetKeyDown(KeyCode.Space) && hit.transform.tag == "Michant")
				hit.transform.eulerAngles = new Vector3(0, 0, 90);
		}
		Debug.DrawRay (transform.position, transform.forward * 10, Color.green);
	}
}
