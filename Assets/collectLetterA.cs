using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collectLetterA : MonoBehaviour {

	public Image HUDLAon;

	// Use this for initialization
	void Start () {


		HUDLAon.GetComponent<Image>().enabled = false;

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);
			HUDLAon.GetComponent<Image>().enabled = true;



		}
	}
}