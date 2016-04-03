using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {

	private Animator anim;
	public float maxSpeed = 7f;

	private Transform groundCheck;

	private bool facingRight = true;
	private bool jump = false;
	private bool grounded = false; 

	public LayerMask groundLayerMask;
	public float jumpForce = 1000f;

	// Use this for initialization
	void Start () {

		groundCheck = transform.Find ("GroundCheck");


	}

	void FixedUpdate (){

		float move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		//anim.SetBool ("Ground", grounded);

		//anim.SetFloat ("vSpeed", RigidbodyConstraints2D.velocity.y);


		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
		if (jump) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2 (0, jumpForce));
			jump = true;
		}
	}


	// Update is called once per frame
	void Update () {

		//if (grounded && Input.GetKeyDown(KeyCode.Space))
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, groundLayerMask);

		if (Input.GetButtonDown ("Jump") && grounded)
			jump = true;

	}

	private void Flip(){

		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Enemy") {
		
			Collider2D[] cols = GetComponents<Collider2D>();
			for (int i = 0; i < cols.Length; i++) {
				cols [i].isTrigger = true;
			}
		}
	}

}



