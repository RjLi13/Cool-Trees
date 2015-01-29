using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	public GameObject mob;
	public GameObject clone;
	public int mobCount;

	 
	// Use this for initialization
	void Start () {

		createEnemies();

	}
	
	// Update is called once per frame
	void Update () {

	}

	void createEnemies(){
		StartCoroutine (SpawnDelay ());
	}

	IEnumerator SpawnDelay(){
		while (true) {
			for (int i = 0; i < mobCount; i++) {
					clone = Instantiate (mob, transform.position, Quaternion.identity) as GameObject;
					yield return new WaitForSeconds (0.5f);
			}
			yield return new WaitForSeconds(1f);
		}

	}
}
