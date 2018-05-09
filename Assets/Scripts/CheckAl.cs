using UnityEngine;
using System.Collections;

public class CheckAl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D (Collision2D coll){
		if(coll.gameObject.tag == "Enmies"){
			Application.LoadLevel("GameStart");
			Destroy(gameObject);
		}
		if(coll.gameObject.tag == "Flag"){
			Application.LoadLevel("GameEnd");
		}
	}
}
