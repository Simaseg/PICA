using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collectLetter7 : MonoBehaviour {

	public Image HUDL7on;

	// Use this for initialization
	void Start () {


		HUDL7on.GetComponent<Image>().enabled = false;

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);
			HUDL7on.GetComponent<Image>().enabled = true;



		}
	}
}