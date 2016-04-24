using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PicaScore : MonoBehaviour {

	public int count;
	public GameObject exitSprite;
	public GameObject blockedSprite;

	// Use this for initialization
	void Start () {

		count = 0;
		exitSprite.SetActive(false);
		blockedSprite.SetActive(true);
	
	}

	// Update is called once per frame

	void Update () {
		if (count == 5) {
			//Application.LoadLevel ("Level1");
			Cursor.visible = true;

			exitSprite.SetActive(true);
			blockedSprite.SetActive(false);
		}
		if (count == 6) {
			Application.LoadLevel ("Level1");
		}

	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.CompareTag ("letter")) 
		{
			count += 1;
		}
}
}
