using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class GameManagerScript : MonoBehaviour {
	public GameObject PausePanel;
	public bool adBool=true;
	InterstitialAd interstitial;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1.0f;
		adBool = true;
		interstitial = new InterstitialAd ("ca-app-pub-6995267039080706/2924311044");
		AdRequest request = new AdRequest.Builder ().Build();
		interstitial.LoadAd (request);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void NextButton()
	{
		Time.timeScale = 1.0f;
		Application.LoadLevel (Application.loadedLevel + 1);

	}

	public void MainMenuButon()
	{
		Application.LoadLevel("MainMenu");
		Time.timeScale = 1.0f;

	}

	public void Restart()
	{

		Application.LoadLevel (Application.loadedLevel);
		Time.timeScale = 1.0f;
		AudioListener.pause = false;
	}

	public void ResumeButton()
	{
		adBool = false;
//		AudioListener.pause = false;
//		adBool = false;
		PausePanel.SetActive (false);

		Time.timeScale = 1.0f;
	}

	public void Pause()
	{ 
		adBool = true;
		if (adBool) {
			if (interstitial.IsLoaded ()) {
				interstitial.Show ();
				adBool = false;
			}
		}
//		AudioListener.pause = true;
		PausePanel.SetActive (true);
		Time.timeScale = 0.01f;

	}

	public void InsideGameRestart()
	{

		Application.LoadLevel (Application.loadedLevel);
		Time.timeScale = 1.0f;
		AudioListener.pause = false;
	}
		

}
