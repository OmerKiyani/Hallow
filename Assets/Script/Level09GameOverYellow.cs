using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Level09GameOverYellow : MonoBehaviour {
	public GameObject LevelfailPanel;
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
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.transform.tag == "RedBall") {
			adBool = true;
			if (adBool) {
				if (interstitial.IsLoaded ()) {
					interstitial.Show ();
					adBool = false;
				}
			}
			LevelfailPanel.SetActive (true);

			Time.timeScale = 0f;
			Debug.Log ("Collide2D");
		}
	}
}
