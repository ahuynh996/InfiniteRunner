using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	private Rigidbody2D rigidbody;
	private Vector2 velocity;

	public float groundCheckRadius;
	public LayerMask whatIsGround;
	
	public float jumpHeight;
	private bool grounded;


	bool timeSlow = false; 
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.IsTouchingLayers(this.gameObject.GetComponent<Collider2D>(), whatIsGround); 
		if(Input.GetKeyDown(KeyCode.Space) && grounded){		
			rigidbody.velocity = new Vector2(0f, jumpHeight);
		}	

		// Slow down powerup
		if (Input.GetKeyDown(KeyCode.LeftControl) && !timeSlow)
		{
			Powerups.SlowDownTime(); 		
			timeSlow = true; 
		}
		else if (Input.GetKeyDown(KeyCode.LeftControl) && timeSlow)	
		{
			Time.timeScale = 1.0F; 
			timeSlow = false; 
		}
	}
}