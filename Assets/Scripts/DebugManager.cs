using UnityEngine;
using System.Collections;

public class DebugManager : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.LoadLevel("MENU_main");
        }
	}
}
