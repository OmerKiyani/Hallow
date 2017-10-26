using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level09GameCompleteYellow : MonoBehaviour {

	public static int Score2;

	public bool touch3=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (touch3) {
			Score2 = Score2 + 1;
			touch3 = false;
		}
	}

void OnTriggerEnter2D(Collider2D col){
	if (col.transform.tag == "YellowBall") {
		Debug.Log ("Ho Gya");
		touch3 = true;
		//			Time.timeScale = 0f;
		//			Debug.Log ("Collide2D");
	}


}
}
