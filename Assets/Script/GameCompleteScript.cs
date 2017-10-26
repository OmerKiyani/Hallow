using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class GameCompleteScript : MonoBehaviour {
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
		if (col.transform.tag == "Player") {
			if (adBool) {
				if (interstitial.IsLoaded ()) {
					interstitial.Show ();
					adBool = false;
				}
			}
			GameCompletePanel.SetActive (true);
			if(Application.loadedLevelName == "Level01")
			{
				PlayerPrefs.SetInt("Level01", 1);
			}
			else if(Application.loadedLevelName == "Level02")
			{
				PlayerPrefs.SetInt("Level02", 1);
			}
			else if(Application.loadedLevelName == "Level03")
			{
				PlayerPrefs.SetInt("Level03", 1);
			}
			Time.timeScale = 0f;
			Debug.Log ("Collide2D");
		}

	}
}
