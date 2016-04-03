using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class P2DestroyPickup : MonoBehaviour {
	

	Rigidbody rb;
	public int count;
	public Text countText;
	public Text winText;


	
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent <Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < -3) {
			transform.position = new Vector3 (-9, 1, -9);
			rb.velocity = new Vector3 (0, 0, 0);
			rb.angularVelocity = new Vector3 (0, 0, 0);
			count = count - 1;
			SetCountText ();

		}
		if (count <= -4) {
			count = -3;
			SetCountText ();
		}

	}
		
	

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("PICKUP")) {
			other.gameObject.GetComponent<CapsuleCollider> ().enabled = false;
			other.gameObject.GetComponent<MeshRenderer> ().enabled = false;
			count = count + 1;
			GetComponent<AudioSource>().Play ();
			SetCountText ();

		}

	}
		void OnCollisionEnter (Collision col) {
		
		if (col.gameObject.tag.Equals ("Collectable")) {
			transform.position = new Vector3 (-9, 1, -9);
			rb.velocity = new Vector3 (0, 0, 0);
			rb.angularVelocity = new Vector3 (0, 0, 0);
			count = count - 2;
			SetCountText ();


		}
	}
	

	void SetCountText ()
	{
		countText.text = "Points joueur rouge:" + count.ToString ();
		if (count >= 10)
		{
			winText.text = "Bravo joueur rouge tu gagne !";
		}
	}
	
}

