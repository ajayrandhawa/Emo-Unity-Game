using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerBEhaviour : MonoBehaviour {

	public int jumpHeight;
	public float moveSpeed;
	public int maxJump;
	public bool isAlive;

	private int numJumps;
	private Rigidbody2D body2D;
	

	void Awake(){
		isAlive = true;
	}


	void Start () {

		numJumps = 0;
		body2D = GetComponent<Rigidbody2D> ();
	}
	

	void Update () {
//		GUI.Box (Rect (10, 10, 150, 30), coins.ToString ());
		if (isAlive == true) {

		

			var val = Input.GetAxis ("Horizontal");
			body2D.velocity = new Vector2 (moveSpeed * val, body2D.velocity.y);
			if (Input.GetKeyDown (KeyCode.Space) && CanJump ()) {
				float x = GetComponent<Rigidbody2D> ().velocity.x;
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (x, jumpHeight);
				++numJumps;
			}	
		}	else {
			Debug.Log("Died");
	}
	


	}
	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.CompareTag ("Ground")) {
			numJumps = 0;
		}
		if (coll.gameObject.tag == "Enmies") {
			if (isAlive) {
				isAlive = false;
			}
		
		}

	}

	void OnTriggerEnter2D(Collider2D collider2d){
		if(Coins.instance != null){
			Coins.instance.SetScore();
			Destroy(collider2d.gameObject);		}
	}


	bool CanJump(){
		return numJumps < maxJump;
	}

}
