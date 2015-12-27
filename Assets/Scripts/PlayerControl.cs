using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	private Rigidbody2D rigidbody;
	private Vector2 velocity;


	public LayerMask whatIsGround;
	
	public float jumpHeight;
	private bool grounded;

	public Sprite fruitSprites;
	private Sprite sprite;
	private BoxCollider2D boxCol;
	public float crouchHeight;


	Animator anim;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();	 
		boxCol = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.IsTouchingLayers(this.gameObject.GetComponent<Collider2D>(), whatIsGround); 
		if(Input.GetKeyDown(KeyCode.Space) && grounded){		
			rigidbody.velocity = new Vector2(0f, jumpHeight);
		}	
		anim.SetBool ("isGrounded", grounded);

		if(Input.GetKeyDown(KeyCode.DownArrow) && grounded){		
			boxCol.size = new Vector2(0,boxCol.size.y/2 );
			anim.SetBool ("ButtonDown", true);
		}	

		anim.SetBool ("ButtonDown", false);

	}
}