using UnityEngine;
using System.Collections;

public class bat_script : MonoBehaviour {
	
	
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
		
		if (mybody.position.x > 18.01 && atEnd == true ) {
			transform.Translate(-speed * 2*Time.deltaTime ,0 ,0);
			if(mybody.position.x < 18.02){
				atEnd = false;
				transform.localScale -= new Vector3(3.0f, 0, 0);
			}
		}
		else if (mybody.position.x < 22.50 && atEnd == false) {
			transform.Translate(speed * 2*Time.deltaTime ,0 ,0);
			if(mybody.position.x > 22.49){
				atEnd = true;
				transform.localScale += new Vector3(3.0f, 0, 0);
			}
		}
	}
}