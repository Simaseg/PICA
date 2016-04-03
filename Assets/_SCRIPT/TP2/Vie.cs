	using UnityEngine;
using System.Collections;

public class Vie : MonoBehaviour {

	Rigidbody rb;
	public int health;
	//public GameObject spider;

	// Use this for initialization
	void Start () {

		rb = GetComponent <Rigidbody> ();
		health = 3;
	}
	
	// Update is called once per frame
	void Update () 
		{
		if (transform.position.y < 25) {
			transform.position = new Vector3 (21, 85, 156);

		}

	}

	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.CompareTag ("Spider"))
		{
			transform.position = new Vector3 (21, 85, 156);
			
		}

}
}