using UnityEngine;
using System.Collections;

public class CapsuleTourne : MonoBehaviour {

	public GameObject[] CapsuleArray;

	// Use this for initialization
	void Start () {
		CapsuleArray = GameObject.FindGameObjectsWithTag ("Ennemi");
		print (CapsuleArray [0].transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < CapsuleArray.Length; i++) {
			if(Vector3.Distance(transform.position, CapsuleArray[i].transform.position) < 3) {
				CapsuleArray[i].transform.Rotate(0,0,3);
			}
		}
	}
}
