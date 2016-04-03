using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PicaScoreLevel2 : MonoBehaviour {

	public int count;

	// Use this for initialization
	void Start () {

		count = 0;
	
	}

	// Update is called once per frame
	void Update () {

		if (count == 5) {
			Application.LoadLevel ("Level1");
			Cursor.visible = true;
	
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
