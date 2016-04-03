using UnityEngine;
using System.Collections;

public class ManagerL2 : MonoBehaviour {

	void Update () {
		if (Input.GetKey ("escape"))
			Application.Quit ();
	}
}