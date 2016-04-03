using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
	
		rb2d = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void FixedUpdate () {
		rb2d.velocity = new Vector2 (transform.localScale.x * speed,rb2d.velocity.y);
	}


	void Update () {
		if (transform.position.x < -90) 
		{
			transform.position = new Vector3 (200, 6, 0);

		}

}
}
