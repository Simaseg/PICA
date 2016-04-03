using UnityEngine;
using System.Collections;

public class respawnL2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (transform.position.y < -70) {
			transform.position = new Vector3 (-55, 2, 0);
			Collider2D[] cols = GetComponents<Collider2D> ();
			for (int i = 0; i < cols.Length; i++) {
				cols [i].isTrigger = false;

			}
		}
	}
}