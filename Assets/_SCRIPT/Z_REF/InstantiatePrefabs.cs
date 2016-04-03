using UnityEngine;
using System.Collections;

public class InstantiatePrefabs : MonoBehaviour {

	public GameObject monPrefab;
	int i =0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject monGO;
			monGO = Instantiate(monPrefab);
			monGO.name += i;
			i++;
		}
	}
}
