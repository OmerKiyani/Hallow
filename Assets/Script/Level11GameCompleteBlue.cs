﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level11GameCompleteBlue : MonoBehaviour {
	public static int Score1;
	public bool touch2=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (touch2) {
			Score1 = Score1 + 1;
			touch2 = false;
		}
	}

void OnTriggerEnter2D(Collider2D col){
	if (col.transform.tag == "BlueBall") {
		Debug.Log ("Ho Gya");
		touch2 = true;
		//			Time.timeScale = 0f;
		//			Debug.Log ("Collide2D");
	}


}
}
