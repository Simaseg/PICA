using UnityEngine;
using System.Collections;

public class CubeTourne : MonoBehaviour {

	public bool cubeTourne = false;
	public int compteurTourne = 0;
	public int directionTourne = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (cubeTourne) {
			transform.Rotate (0, 0.3f * (compteurTourne % 5 + 1) * directionTourne, 0);
		}
	}

	void OnMouseDown() {
//		// Exercice #2 maniere normale
//		if (cubeTourne == true) {
//			cubeTourne = false;
//		} else {
//			cubeTourne = true;
//		}
		// Exercice #2 optimal
		//cubeTourne = !cubeTourne;
		if (cubeTourne)
			cubeTourne = false;
		else {
			compteurTourne++;
			cubeTourne = true;
			directionTourne *= -1;
			print ("compteurTourne % 5 + 1 = " + (compteurTourne % 5 + 1));
			//if (compteurTourne > 5) compteurTourne = 1;
		}




	}
}

// Exercice #1 : Faire que le cube tourne seulement quand on clique dessus. Ca veut dire que
//               au départ le cube ne tourne pas, mais quand je clique dessus 1 fois il se
//               met a tourner.

// Exercice #2 : Faire que le cube arrete de tourner quand on reclique dessus.

// Exercice #3 : Faire que le cube tourne de plus en plus vite a chaque fois.

// Exercice #4 : Faire qu'apres 5 augmentation de vitesse, le cube revient a sa vitesse 
//               originale.

// Exercice #5 : Faire que le cube inverse sa direction a chaque fois qu'il tourne.