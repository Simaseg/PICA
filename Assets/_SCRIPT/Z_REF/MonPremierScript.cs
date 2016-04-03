using UnityEngine;
using System.Collections;

public class MonPremierScript : MonoBehaviour {

	public int i;
	public int nombre;
	float pi = 13.1415926f;
	string prenom = "Louis-Félix";
	string nom = "Cauchon";
	public bool bool1;
	public bool bool2;
	public bool bool3;

	// Use this for initialization
	void Start () {
		//i = i + 2;
		// Méthode plus rapide
//		i += 2; // Addition
//		i -= 2; // Soustraction
//		i *= 2; // Multiplication
//		i /= 2; // Division
		//i++; // Rajoute 1;
		//i--; // Soustrait 1;
		//print (prenom + " " + nom); // Concatenation de string avec le '+'
		// Fonctionnent sur les nombres et les booléennes
		// == Opérateur d'équivalence "est-ce que c'est égale"
		// != "Est-ce que ce n'est pas égale"
		// <
		// >
		// <=
		// >=
		if (bool1 == bool2 == bool3) {
			print ("C'est vrai mon homme!");
		} else {
			print ("T'es completement dans le champs!! ");
		}

	}
	
	// Update is called once per frame
	void Update () {

	}
}
