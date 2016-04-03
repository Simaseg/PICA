using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RayCastCamera_2 : MonoBehaviour {

	private Camera cam;
	private RaycastHit hit;
	private Image img;
	public GameObject Cible;
	public GameObject photo1;
	public GameObject photo2;
	public GameObject photo3;
	public GameObject photo4;
	public GameObject photo5;
	public GameObject photo6;
	public GameObject photo7;
	public GameObject photo8;
	public GameObject photo9;
	public static int actualProgression = 0;
	public int count = 0;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera> ();
		img = Cible.GetComponent<Image> ();
		count = 0;
	}
	
	// Update is called once per frame
	void Update (){

	
		img.color = Color.white;




		Ray ray = cam.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));
		if (Physics.Raycast (ray, out hit))
			print ("Touche a de quoi");
		
		if (hit.transform.tag == "photo1") {
			img.color = Color.green;
			if (Input.GetMouseButtonDown (0))
				{
				Destroy (hit.transform.gameObject);
				count += 1;
				}
		
		}


		if (count == 5) {
			RayCastCamera.actualProgression = 1;
			Application.LoadLevel ("LOST in time");
			
		}
	
	}
}
	