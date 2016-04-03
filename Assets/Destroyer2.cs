using UnityEngine;
using System.Collections;

public class Destroyer2 : MonoBehaviour {



	void OnTriggerExit2D (Collider2D other){
	
		Destroy (other.gameObject);

	}



}
