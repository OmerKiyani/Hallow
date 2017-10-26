using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButonScropt : MonoBehaviour {
	public GameObject LineObject;
	public bool MouseAct=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (EventSystem.current.IsPointerOverGameObject ()) {
			LineObject.GetComponent<LineCreator> ().enabled = false;
		} else {
			if (Input.GetMouseButtonDown (0)) {
				
				LineObject.GetComponent<LineCreator> ().enabled = true;
			}
		}
	}

	void OnMouseOver()
	{
		MouseAct = true;
		Debug.Log ("Button Is Hovered By Mouse");
	}
	public void OnPressed(float z)
	{
		if (MouseAct) {
			Debug.Log ("Button Is Hovered By Mouse");
		}
		if (z >= 1f) {
			LineObject.GetComponent<LineCreator> ().enabled = false;
		} else if (z <= 0f) {
			LineObject.GetComponent<LineCreator> ().enabled = true;
		}
	
	}
}
