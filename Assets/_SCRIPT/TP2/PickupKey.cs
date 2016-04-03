using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickupKey : MonoBehaviour {

	public int count;
	public Image keyHUD1on;
	public Image keyHUD2on;
	public Image keyHUD3on;

	// Use this for initialization
	void Start () {
	
		count = 0;
		keyHUD1on.GetComponent<Image>().enabled = false;
		keyHUD2on.GetComponent<Image>().enabled = false;
		keyHUD3on.GetComponent<Image>().enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
	
		if (count == 3) {
			RayCastCamera.actualProgression = 2;
			Application.LoadLevel("LOST in time");
		}
	
		if (count == 1) {
		
			keyHUD1on.GetComponent<Image>().enabled = true;
		}

		if (count == 2) {
			
			keyHUD2on.GetComponent<Image>().enabled = true;
			
		}

		if (count == 3) {
			
			keyHUD3on.GetComponent<Image>().enabled = true;
			
		}

	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Key"))
		{
			other.gameObject.SetActive (false);
			count += 1;

		}



}
}
