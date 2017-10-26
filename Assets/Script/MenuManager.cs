using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class MenuManager : MonoBehaviour {

	public GameObject SoundOnButton;
	public GameObject SoundOffButton;
	public static bool Mute = false;
	public GameObject loadingPanel;
	public bool adBool=true;
	InterstitialAd interstitial;

	// Use this for initialization
	void Start () {
		loadingPanel.SetActive (false);
		AudioListener.pause=false;
		Mute = false;


		adBool = true;
		interstitial = new InterstitialAd ("ca-app-pub-6995267039080706/2924311044");
		AdRequest request = new AdRequest.Builder ().Build();
		interstitial.LoadAd (request);

		BannerView banner = new BannerView ("ca-app-pub-6995267039080706/2377516135", AdSize.Banner, AdPosition.TopLeft);
		AdRequest requestbanner = new AdRequest.Builder ().Build ();
		banner.LoadAd (requestbanner);
	}

	// Update is called once per frame
	void Update () {
		if (adBool) {
			if (interstitial.IsLoaded ()) {
				interstitial.Show ();
				adBool = false;
			}
		}
	}

	public void OnPlay(){
		loadingPanel.SetActive (true);
		Application.LoadLevel ("LevelSelection");
	}

	public void RateUs(){
		Application.OpenURL ("https://play.google.com/store/apps/developer?id=com.aepg.drawyourhalloweenpath2017");
	}
	public void MoreGames(){
		Application.OpenURL ("https://play.google.com/store/apps/developer?id=Easy%20Peasy%20Games&hl=en");
	}
	public void PrivacyPolicy(){
		Application.OpenURL ("http://easypeasygames.blogspot.com/");
	}
	public void Sound()
	{

		if(!Mute)
		{
			Mute = !Mute;
			AudioListener.pause = true;
			SoundOnButton.SetActive (false);
			SoundOffButton.SetActive (true);
		}
		else
		{
			Mute = !Mute;
			AudioListener.pause = false;
			SoundOnButton.SetActive (true);
			SoundOffButton.SetActive (false);
		}
	}
}
