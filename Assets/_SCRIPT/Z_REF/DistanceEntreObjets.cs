using UnityEngine;
using System.Collections;

public class DistanceEntreObjets : MonoBehaviour {

	public GameObject autreObjet;

	// Use this for initialization
	void Start () {
		//autreObjet = GameObject.FindGameObjectWithTag ("Joueur");
	}
	
	// Update is called once per frame
	void Update () {
		print (Vector3.Distance(transform.position, autreObjet.transform.position));
	}
}
// Exercice : Faite que si la distance entre le cube et l'une des capsules est inférieure
//			  a 1, la capsule tourne sur son axe des Z.