using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {


	void Update () {
		if (Input.GetKey ("escape"))
			Application.Quit ();

        if (Input.GetButtonDown("Submit") && SceneManager.GetActiveScene().name == "Instructions") {
            SceneManager.LoadScene("Level2");
        }
	}

	public void LoadLevel (string LevelToLoadTo){
		Application.LoadLevel (LevelToLoadTo);
	}


	}
