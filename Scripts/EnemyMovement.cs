using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public GameObject player;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement(){
		float step = speed * Time.deltaTime;
		//Put player sprite game object in
		transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
		transform.position = new Vector2(transform.position.x, 0);

	}
	
}
