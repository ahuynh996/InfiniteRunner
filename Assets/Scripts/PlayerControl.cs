using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	private Rigidbody2D rigidbody;
	private Vector2 velocity;

	public float groundCheckRadius;
	public LayerMask whatIsGround;
	
	public float jumpHeight;
	private bool grounded;

	bool isBarrierOn = false;
	bool isTouchingEnemy;
	public LayerMask enemy;
	
	bool hasDash = false;
	private Vector2 position;
	public float dash;

	bool timeSlow = false; 
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.IsTouchingLayers(this.gameObject.GetComponent<Collider2D>(), whatIsGround);
		isTouchingEnemy = Physics2D.IsTouchingLayers(this.gameObject.GetComponent<Collider2D>(), enemy);
		  
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
		
		if(Input.GetKeyDown(KeyCode.A) && !hasDash)
		{
			rigidbody.position = new Vector2(dash, -1.2f);	
			hasDash = true;
			
		} else if(hasDash){
			rigidbody.position = new Vector2(-2.198f, -1.153f);
			hasDash = false;
		}
		
		if(isBarrierOn && isTouchingEnemy){
			isBarrierOn = false;
		}
	}
}