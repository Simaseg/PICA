using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectLetterI : MonoBehaviour {

	public Image HUDLPon;





	// Use this for initialization
	void Start () {


		HUDLPon.GetComponent<Image>().enabled = false;

	}



	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);
			HUDLPon.GetComponent<Image> ().enabled = true;
		


		}
	}



}
