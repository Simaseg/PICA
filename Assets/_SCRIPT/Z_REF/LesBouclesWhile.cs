using UnityEngine;
using System.Collections;

public class LesBouclesWhile : MonoBehaviour {

	int i = 0;
	public int valeur = 5;
	// Use this for initialization
	void Start () {
	
		while (i <= 100) {
			print(i);
			i += valeur;

		}

		print ("Fin de la boucle");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
// Exercice : Imprimez-moi les multiples d'une variable publique 
//            tant qu'il ne dépasse pas 100.