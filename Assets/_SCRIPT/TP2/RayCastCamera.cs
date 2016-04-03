using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RayCastCamera : MonoBehaviour {

	private Camera cam;
	private RaycastHit hit;
	private Image img;
	public GameObject Cible;
	public static int actualProgression = 0;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera> ();
		img = Cible.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update (){

	
		img.color = Color.white;


		Ray ray = cam.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));
		if (Physics.Raycast (ray, out hit))
			print ("Touche a de quoi");
		
		if (hit.transform.tag == "EnterLevel1" && actualProgression == 0 ) {
			img.color = Color.green;
			if (Input.GetMouseButtonDown (0))
				Application.LoadLevel ("MenuLoadLevel1");
		}

		if (hit.transform.tag == "EnterLevel2" && actualProgression == 1 ) {
			img.color = Color.green;
			if (Input.GetMouseButtonDown (0))
				Application.LoadLevel ("MenuLoadLevel2");
		}

		if (hit.transform.tag == "EnterLevel3" && actualProgression == 2 ) {
			img.color = Color.green;
			if (Input.GetMouseButtonDown (0))
				Application.LoadLevel ("Level3");
		}

	
	}
}
	