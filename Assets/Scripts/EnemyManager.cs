using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
	
	public GameObject enemy;
	public float spawnTime;
	public float enemyTime;
	public Transform spawnPosition;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	void Spawn () {
		Instantiate (enemy, spawnPosition.position, spawnPosition.rotation);
	}
}
