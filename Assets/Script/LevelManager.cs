using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using ChartboostSDK;
public class LevelManager : MonoBehaviour {
	public float timer=3f;

	public GameObject LoadingPanel;

	public bool adBool=true;
	public GameObject TipPanel,TipPanel1,TipPanel2,TipPanel3,TipPanel4,TipPanel5,TipPanel6,TipPanel7,TipPanel8,TipPanel9,TipPanel10,TipPanel11,TipPanel12,TipPanel13,TipPanel14,TipPanel15,TipPanel16,TipPanel17,TipPanel18,TipPanel19,TipPanel20;
	public Sprite leveltwo,levelthree,levelfour,levelfive,levelsix,levelseven,leveleight,levelnine,levelten,leveleleven,
	leveltwelve,levelthirteen,levelfourteen,levelfifteen,levelsixteen,levelseventeen,
	leveleighteen,levelninteen,leveltwenty;

	public Button leveltwobtn,levelthreebtn,levelfourbtn,levelfivebtn,levelsixbtn,levelsevenbtn,leveleightbtn,levelninebtn,leveltenbtn,levelelevenbtn,
	leveltwelvebtn,levelthirteenbtn,levelfourteenbtn,levelfifteenbtn,levelsixteenbtn,levelseventeenbtn,
	leveleighteenbtn,levelninteenbtn,leveltwentybtn;
	// Use this for initialization
	void Start () {
		Chartboost.cacheInterstitial (CBLocation.Default);


		checklevelfirst ();
		checklevelsecond ();
		checklevelthird ();
		checklevelfourth ();
		checklevelfive ();
		checklevelsix ();
		checklevelseven ();
		checkleveleight ();
		checklevelnine ();
		checklevelten ();
		checkleveleleven ();
		checkleveltwelve ();
		checklevelthirteen ();
		checklevelfourteen ();
		checklevelfifteen ();
		checklevelsexteen ();
		checklevelseventeen ();
		checkleveleighteen ();
		checklevelnineteen ();
		//		checkleveltwenty ();



	}

	// Update is called once per frame
	void Update () {
		if (adBool) {
			if (Chartboost.hasInterstitial (CBLocation.Default)) {
				Chartboost.showInterstitial (CBLocation.Default);
				adBool = false;
			}
		}
	}
	public void changeleveltwotx()
	{
		leveltwobtn.image.sprite = leveltwo;
	}
	public void changelevelthreetx()
	{
		levelthreebtn.image.sprite = levelthree;
	}
	public void changelevelfourtx()
	{
		levelfourbtn.image.sprite = levelfour;
	}
	public void changelevelfivetx()
	{
		levelfivebtn.image.sprite = levelfive;
	}
	public void changelevelsixtx()
	{
		levelsixbtn.image.sprite = levelsix;
	}

	public void changelevelseventx()
	{
		levelsevenbtn.image.sprite = levelseven;
	}

	public void changeleveleighttx()
	{
		leveleightbtn.image.sprite = leveleight;
	}

	public void changelevelninetx()
	{
		levelninebtn.image.sprite = levelnine;
	}

	public void changeleveltentx()
	{
		leveltenbtn.image.sprite = levelten;
	}
	public void changeleveleleventx()
	{
		levelelevenbtn.image.sprite = leveleleven;
	}
	public void changeleveltwelvetentx()
	{
		leveltwelvebtn.image.sprite = leveltwelve;
	}
	public void changelevelthirteententx()
	{
		levelthirteenbtn.image.sprite = levelthirteen;
	}
	public void changelevelfourteentx()
	{
		levelfourteenbtn.image.sprite = levelfourteen;
	}
	public void changelevelfifiteentx()
	{
		levelfifteenbtn.image.sprite = levelfifteen;
	}
	public void changelevelsixteentx()
	{
		levelsixteenbtn.image.sprite = levelsixteen;
	}
	public void changelevelseventeentx()
	{
		levelseventeenbtn.image.sprite = levelseventeen;
	}
	public void changeleveleighteentx()
	{
		leveleighteenbtn.image.sprite = leveleighteen;
	}
	public void changelevelninteentx()
	{
		levelninteenbtn.image.sprite = levelninteen;
	}
	public void changeleveltwentytx()
	{
		leveltwentybtn.image.sprite = leveltwenty;
	}






	public void Loadlevelfirst(){
		LoadingPanel.SetActive (true);
		Application.LoadLevel("Level01");
	}
	public void loadleveltwo()
	{
		if (leveltwobtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log ("First clear the level you moron");

		} else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level02");
		}
	}
	public void Loadlevelthree()
	{

		if (levelthreebtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level03");
		}

	}
	public void Loadlevelfour()
	{

		if (levelfourbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level04");
		}
	}
	public void Loadlevelfive()
	{

		if (levelfivebtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level05");
		}
	}
	public void Loadlevelsix()
	{

		if (levelsixbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level06");
		}
	}
	public void Loadlevelseven()
	{

		if (levelsevenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level07");
		}
	}
	public void Loadleveleight()
	{

		if (leveleightbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level08");
		}
	}
	public void Loadlevelnine()
	{

		if (levelninebtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level09");
		}
	}
	public void Loadlevelten()
	{

		if (leveltenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level10");
		}
	}
	public void LoadlevelEleven()
	{

		if (levelelevenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			Debug.Log ("Level11");
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level11");
		}
	}
	public void LoadlevelTwelve()
	{

		if (leveltwelvebtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level12");
		}
	}
	public void LoadlevelThirteen()
	{

		if (levelthirteenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level13");
		}
	}
	public void LoadlevelFourteen()
	{

		if (levelfourteenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level14");
		}
	}
	public void LoadlevelFifteen()
	{

		if (levelfifteenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level15");
		}
	}
	public void LoadlevelSixteen()
	{

		if (levelsixteenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level16");
		}
	}
	public void LoadlevelSeventeen()
	{

		if (levelseventeenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level17");
		}
	}
	public void LoadlevelEighteen()
	{

		if (leveleighteenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level18");
		}
	}
	public void LoadlevelNinteen()
	{

		if (levelninteenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level19");
		}
	}
	public void LoadlevelTwenty()
	{

		if (leveltwentybtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level20");
		}
	}

	public void tip1(){
		TipPanel.SetActive (true);
	}
	public void CloseTip1(){
		TipPanel.SetActive (false);
	}




	public void tip2(){
		TipPanel1.SetActive (true);
	}
	public void CloseTip2(){
		TipPanel1.SetActive (false);
	}




	public void tip3(){
		TipPanel2.SetActive (true);
	}
	public void CloseTip3(){
		TipPanel2.SetActive (false);
	}




	public void tip4(){
		TipPanel3.SetActive (true);
	}
	public void CloseTip4(){
		TipPanel3.SetActive (false);
	}






	public void tip5(){
		TipPanel4.SetActive (true);
	}
	public void CloseTip5(){
		TipPanel4.SetActive (false);
	}




	public void tip6(){
		TipPanel5.SetActive (true);
	}
	public void CloseTip6(){
		TipPanel5.SetActive (false);
	}





	public void tip7(){
		TipPanel6.SetActive (true);
	}
	public void CloseTip7(){
		TipPanel6.SetActive (false);
	}





	public void tip8(){
		TipPanel7.SetActive (true);
	}
	public void CloseTip8(){
		TipPanel7.SetActive (false);
	}





	public void tip9(){
		TipPanel8.SetActive (true);
	}
	public void CloseTip9(){
		TipPanel8.SetActive (false);
	}





	public void tip10(){
		TipPanel9.SetActive (true);
	}
	public void CloseTip10(){
		TipPanel9.SetActive (false);
	}


	public void tip11(){
		TipPanel10.SetActive (true);
	}
	public void CloseTip11(){
		TipPanel10.SetActive (false);
	}




	public void tip12(){
		TipPanel11.SetActive (true);
	}
	public void CloseTip12(){
		TipPanel11.SetActive (false);
	}




	public void tip13(){
		TipPanel12.SetActive (true);
	}
	public void CloseTip13(){
		TipPanel12.SetActive (false);
	}




	public void tip14(){
		TipPanel13.SetActive (true);
	}
	public void CloseTip14(){
		TipPanel13.SetActive (false);
	}






	public void tip15(){
		TipPanel14.SetActive (true);
	}
	public void CloseTip15(){
		TipPanel14.SetActive (false);
	}




	public void tip16(){
		TipPanel15.SetActive (true);
	}
	public void CloseTip16(){
		TipPanel15.SetActive (false);
	}





	public void tip17(){
		TipPanel16.SetActive (true);
	}
	public void CloseTip17(){
		TipPanel16.SetActive (false);
	}





	public void tip18(){
		TipPanel17.SetActive (true);
	}
	public void CloseTip18(){
		TipPanel17.SetActive (false);
	}





	public void tip19(){
		TipPanel18.SetActive (true);
	}
	public void CloseTip19(){
		TipPanel18.SetActive (false);
	}





	public void tip20(){
		TipPanel19.SetActive (true);
	}
	public void CloseTip20(){
		TipPanel19.SetActive (false);
	}


	void checklevelfirst()
	{
		if (PlayerPrefs.GetInt ("Level01") == 1)
			changeleveltwotx ();
	}
	void checklevelsecond (){
		if (PlayerPrefs.GetInt ("Level02") == 1)
			changelevelthreetx ();
	}
	void checklevelthird (){

		if (PlayerPrefs.GetInt ("Level03") == 1)
			changelevelfourtx ();
	}
	void checklevelfourth(){

		if (PlayerPrefs.GetInt ("Level04") == 1)
			changelevelfivetx ();
	}
	void checklevelfive(){

		if (PlayerPrefs.GetInt ("Level05") == 1)
			changelevelsixtx ();
	}
	void checklevelsix(){

		if (PlayerPrefs.GetInt ("Level06") == 1)
			changelevelseventx();
	}
	void checklevelseven(){

		if (PlayerPrefs.GetInt ("Level07") == 1)
			changeleveleighttx ();
	}
	void checkleveleight(){

		if (PlayerPrefs.GetInt ("Level08") == 1)
			changelevelninetx ();
	}
	void checklevelnine(){

		if (PlayerPrefs.GetInt ("Level09") == 1)
			changeleveltentx ();
	}
	void checklevelten(){

		if (PlayerPrefs.GetInt ("Level10") == 1)
			changeleveleleventx ();
	}
	void checkleveleleven (){

		if (PlayerPrefs.GetInt ("Level11") == 1)
			changeleveltwelvetentx ();
	}
	void checkleveltwelve (){

		if (PlayerPrefs.GetInt ("Level12") == 1)
			changelevelthirteententx ();
	}
	void checklevelthirteen (){

		if (PlayerPrefs.GetInt ("Level13") == 1)
			changelevelfourteentx();
	}
	void checklevelfourteen  (){

		if (PlayerPrefs.GetInt ("Level14") == 1)
			changelevelfifiteentx();
	}
	void checklevelfifteen  (){

		if (PlayerPrefs.GetInt ("Level15") == 1)
			changelevelsixteentx();
	}
	void checklevelsexteen  (){

		if (PlayerPrefs.GetInt ("Level16") == 1)
			changelevelseventeentx();
	}
	void checklevelseventeen  (){

		if (PlayerPrefs.GetInt ("Level17") == 1)
			changeleveleighteentx();
	}

	void checkleveleighteen (){

		if (PlayerPrefs.GetInt ("Level18") == 1)
			changelevelninteentx();
	}

	void checklevelnineteen (){

		if (PlayerPrefs.GetInt ("Level19") == 1)
			changeleveltwentytx();
	}
	public void Back(){
		Application.LoadLevel("MainMenu");
	}

}
