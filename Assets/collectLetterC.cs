using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class collectLetterC : MonoBehaviour {

	public Image HUDLCon;

	// Use this for initialization
	void Start () {


		HUDLCon.GetComponent<Image>().enabled = false;

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);
			HUDLCon.GetComponent<Image>().enabled = true;



		}
	}
}