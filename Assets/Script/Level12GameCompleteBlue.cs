using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Level12GameCompleteBlue : MonoBehaviour {
	public GameObject GameCompletePanel;
	public int Score1;
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
		if (touch2) {
			Score1 = Score1 + 1;
			touch2 = false;
		}

		if(Score1>=1 && Level12GameCompleteRed.Score1>=1 ){
			adBool = true;
			if (adBool) {
				if (interstitial.IsLoaded ()) {
					interstitial.Show ();
					adBool = false;
				}
			}
			GameCompletePanel.SetActive (true);
			if(Application.loadedLevelName == "Level12")
			{
				PlayerPrefs.SetInt("Level12", 1);
			}
			Time.timeScale = 0f;
		}
	}

void OnTriggerEnter2D(Collider2D col){
	if (col.transform.tag == "YellowBall") {
		Debug.Log ("Ho Gya");
		touch2 = true;
		//			Time.timeScale = 0f;
		//			Debug.Log ("Collide2D");
	}


}
}
