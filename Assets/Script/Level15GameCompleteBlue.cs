using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Level15GameCompleteBlue : MonoBehaviour {
	public GameObject GameCompletePanel;
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
	if (col.transform.tag == "BlueBall") {
			adBool = true;
			if (adBool) {
				if (interstitial.IsLoaded ()) {
					interstitial.Show ();
					adBool = false;
				}
			}
			GameCompletePanel.SetActive (true);
			if(Application.loadedLevelName == "Level15")
			{
				PlayerPrefs.SetInt("Level15", 1);
			}
			Time.timeScale = 0f;
		Debug.Log ("Ho Gya");
		
		//			Time.timeScale = 0f;
		//			Debug.Log ("Collide2D");
	}


}
}
