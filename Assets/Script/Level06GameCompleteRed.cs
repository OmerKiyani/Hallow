﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Level06GameCompleteRed : MonoBehaviour {
	public GameObject GameCompletePanel;
	public int Score;
	public bool touch1=false;
	public bool adBool=true;
	InterstitialAd interstitial;
	// Use this for initialization
	void Start () {
		adBool = true;
		interstitial = new InterstitialAd ("ca-app-pub-6995267039080706/2924311044");
		AdRequest request = new AdRequest.Builder ().Build();
		interstitial.LoadAd (request);
	}
	
	// Update is called once per frame
	void Update () {
		if (touch1) {
			Score = Score + 1;
			touch1 = false;
		}

		if(Score>=1 && Level06GameCompleteBlue.Score1>=1 && Level06GameCompleteYellow.Score2>=1){
			adBool = true;
			if (adBool) {
				if (interstitial.IsLoaded ()) {
					interstitial.Show ();
					adBool = false;
				}
			}
			GameCompletePanel.SetActive (true);
			if(Application.loadedLevelName == "Level06")
			{
				PlayerPrefs.SetInt("Level06", 1);
			}
			Time.timeScale = 0f;
		}
	}

void OnTriggerEnter2D(Collider2D col){
	if (col.transform.tag == "RedBall") {
		Debug.Log ("Ho Gya");
		touch1 = true;
		//			Time.timeScale = 0f;
		//			Debug.Log ("Collide2D");
	}


}
}
