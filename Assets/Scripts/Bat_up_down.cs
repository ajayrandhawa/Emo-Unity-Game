using UnityEngine;
using System.Collections;

public class Bat_up_down : MonoBehaviour {
	
	
	private Rigidbody2D mybody;
	private float temp = 0;
	public float speed = 0.2f;
	private bool atEnd = true;
	
	
	// Use this for initialization
	void Awake() {
		mybody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (mybody.position.y > -2.98 && atEnd == true ) {
			transform.Translate(0,-speed *Time.deltaTime ,0);
			if(mybody.position.y < -2.98){
				atEnd = false;
			}
		}
		else if (mybody.position.y < 3.2 && atEnd == false) {
			transform.Translate(0,speed *Time.deltaTime ,0);
			if(mybody.position.y > 3.2 ){
				atEnd = true;
			}
		}
	}
}