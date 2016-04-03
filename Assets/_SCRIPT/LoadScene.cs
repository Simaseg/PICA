using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {


	void Update () {
		if (Input.GetKey ("escape"))
			Application.Quit ();
	}

	public void LoadLevel (string LevelToLoadTo){
		Application.LoadLevel (LevelToLoadTo);
	}


	}
