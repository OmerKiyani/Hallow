using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Level05GameComplete : MonoBehaviour {
	public GameObject GameCompletePanel;
	public int Score;
	public int Score1;
	public bool touch1=false;
	public bool touch2=false;
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
//		if (touch2) {
//			Score1 = Score1 + 1;
//			touch2 = false;
//		}
//		if (Score >= 1 && Score1>=1) 
		if(Score>=1 && Level05GameComplete1.Score1>=1){
			adBool = true;
			if (adBool) {
				if (interstitial.IsLoaded ()) {
					interstitial.Show ();
					adBool = false;
				}
			}
			GameCompletePanel.SetActive (true);
			if(Application.loadedLevelName == "Level05")
			{
				PlayerPrefs.SetInt("Level05", 1);
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
