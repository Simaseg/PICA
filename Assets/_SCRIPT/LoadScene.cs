using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {


	void Update () {
		if (Input.GetKey ("escape"))
			Application.Quit ();

        if (Input.GetButtonDown("Submit") && Application.loadedLevelName == "Instructions") {
			Application.LoadLevel("Level2");
        }
	}

	public void LoadLevel (string LevelToLoadTo){
		Application.LoadLevel (LevelToLoadTo);
	}


	}
