using UnityEngine;
using System.Collections;

public class Cube2R2 : MonoBehaviour {

	public bool cubeTourne = false;
	public int vitesseTourne = 0;
	public int directionTourne = 1;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		if (cubeTourne) {
			transform.Rotate (0, 0.3f  * (vitesseTourne % 5 + 1) * directionTourne, 0);
		}
	}
	
	void OnMouseDown() {
		// exercice # 2 manière normale

		if (cubeTourne) 
		
		
			cubeTourne = false;

		else 
		{
			vitesseTourne++;
			cubeTourne  = true;
			directionTourne *= -1;
		//	directionTourne = directionTourne * -1
			
			//if (compteurTourne > 5) compteurTourne = 1;

		}

		// Ex 2 maniére optimale

		//cubeTourne = !cubeTourne;


}
}

