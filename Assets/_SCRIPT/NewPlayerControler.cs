using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class NewPlayerControler : MonoBehaviour {


	

	private Rigidbody2D rb2d;

	public float maxSpeed = 10f;
	private bool facingRight = true;

	public int count;

	public AudioClip[] audioclip;

	bool jumpsound ;

	bool grounded = false;
	public Transform groundCheck;
	float groundRaidius = 0.2f;
	public LayerMask whatIsGround;
	private float jumpForce = 3000f;
	public bool bigJump = false; 
	//Animator anim;

	// Use this for initialization
	void Start () {
	
		rb2d = GetComponent<Rigidbody2D> ();
		count = 0;


	}

	void PlaySound (int clip) {

		GetComponent<AudioSource>().clip = audioclip[clip];
		GetComponent<AudioSource>().Play ();
	

	
	}

	// Update is called once per frame
	void Update () {
        Debug.Log(grounded);
		if (Input.GetKeyDown (KeyCode.Space) && grounded)
		{	
			rb2d.AddForce(new Vector2 (0,jumpForce));
			PlaySound (0);
		



		}

		if (transform.position.y < -70) {
			transform.position = new Vector3 (-55, 30, 0);
		}

		if (bigJump == true)
			jumpForce = 4300f;


			}
	

	void FixedUpdate (){

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRaidius, whatIsGround);


		float move = Input.GetAxis ("Horizontal");
		rb2d.velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();

	
}

	private void Flip(){

		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}


	void OnCollisionEnter2D (Collision2D other)
	{

	}

	void OnTriggerEnter2D (Collider2D other)
	{


		if (other.gameObject.CompareTag ("BIG"))
		{
			transform.localScale = new Vector3(transform.localScale.x * 1.7f, transform.localScale.y * 1.7f, transform.localScale.z * 1.7f);

			bigJump = true;
			PlaySound (2);

		}

		if (other.gameObject.CompareTag ("Hat")) 
			transform.position = new Vector3 (-14, 14, 0);

		if (other.gameObject.CompareTag ("Bomb")) 
			transform.position = new Vector3 (-30, -12, 0);

		if (other.gameObject.CompareTag ("letter")) 
			PlaySound (3);

		if (other.gameObject.tag == "BLACK") {
			Camera.main.GetComponent<UnityStandardAssets.ImageEffects.ScreenOverlay>().enabled = true;
			PlaySound (4);
		}
	

		if (other.gameObject.tag == "Ennemi") 
		{
			transform.position = new Vector3 (-55, 30, 0);

//			Collider2D[] cols = GetComponents<Collider2D>();
//			for (int i = 0; i < cols.Length; i++) {
//				cols [i].isTrigger = true;
				PlaySound (1);
			}





	}



}