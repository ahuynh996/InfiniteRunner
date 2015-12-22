using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	
	private static int score; 
	Text text; 
	
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>(); 
		// Reset score per round 
		score = 0; 
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + score; 
	}
	
	public static void AddScore(int value) 
	{
		score += value; 
	} 
	
	public static int GetScore() 
	{
		return score; 
	} 
}
