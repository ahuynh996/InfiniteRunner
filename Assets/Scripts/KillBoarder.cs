using UnityEngine;
using System.Collections;

public class KillBoarder : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Destroy(other.gameObject);
			
			ScoreController.AddScore(10); 		
		 } 
	}
}
