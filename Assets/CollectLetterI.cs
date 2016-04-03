using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectLetterP : MonoBehaviour {

	public Image HUDLIon;

	// Use this for initialization
	void Start () {


		HUDLIon.GetComponent<Image>().enabled = false;

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);
			HUDLIon.GetComponent<Image>().enabled = true;



		}
	}
}