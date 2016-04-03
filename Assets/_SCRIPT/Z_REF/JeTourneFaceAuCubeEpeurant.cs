using UnityEngine;
using System.Collections;

public class JeTourneFaceAuCubeEpeurant : MonoBehaviour {

	public GameObject Cube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, Cube.transform.position) < 3) 
			transform.Rotate (0, 0, 3);
	}
}
