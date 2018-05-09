using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coins : MonoBehaviour {

	 public static Coins instance;

	Text myscore;
	int coin = 0;

	void Awake () {
		myscore = GameObject.Find("Score_Text").GetComponent<Text> ();

		if (instance == null)
			instance = this;
	}
	
	public void SetScore(){
		coin++;
		myscore.text = "" + coin;

	}

	void OnTriggerEnter2D(Collider2D collider2d){
		if (collider2d.tag == "coin") {
			SetScore ();
			Destroy (collider2d.gameObject);	
		}
	}
	}

