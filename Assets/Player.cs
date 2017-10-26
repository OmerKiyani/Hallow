using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Rigidbody2D rb;

	void Update ()
	{

		if (Input.GetButtonDown("Play"))
		{

			rb.bodyType = RigidbodyType2D.Dynamic;
		}
	}

	public void InsideGamePlay(){
		Time.timeScale = 1.0f;
		rb.bodyType = RigidbodyType2D.Dynamic;
	}

}
