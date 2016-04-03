using UnityEngine;
using System.Collections;

public class LesFonctions : MonoBehaviour {

	string test = "test";
	float f;

	// Use this for initialization
	void Start () {

		//print (addition (3.8f, 2.7f) + 5.3f);
		f = addition (3.8f, 2.7f) + 4.2f;
		print (f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DitMoiBonjour() {
		print ("Bonjour les potes!");
	}

	string DitAllo() {
		return "Allo!";
	}

	string DitBonjourPrenom(string prenom){
		return "Bonjour! " + prenom;
	}

	string DitBonjourPrenomNom(string prenom, string nom){
		return "Bonjour! " + prenom + " " + nom;
	}

	int addition (int a, int b) {
		return a + b;
	}

	int addition (int a, int b, int c) {
		return a + b + c;
	}

	float addition (float a, float b) {
		return a + b;
	}
}
