using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {
	
	public LevelManager levelmanager;
	public float enemySpeed;

	private Rigidbody2D enemyRigidBody;
	private bool isHit = false;	
	// Use this for initialization
	void Start () {
		levelmanager = FindObjectOfType<LevelManager>();
		enemyRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		//Checks if player is hit and stops enemy
		if(isHit == false)
			enemyRigidBody.velocity = new Vector2(enemySpeed, 0f);
		else
			enemyRigidBody.velocity = new Vector2(0f,0f);	
	}
	
	//Checks if player and enemy have collided
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			Debug.Log("Enter trigger");
			
			isHit = true;
			levelmanager.LoadLevel ("Lose");
		}
	}
}

