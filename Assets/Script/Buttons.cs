﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		if(transform.name=="Replay" || transform.name=="Play")
		Application.LoadLevel ("Gameplay");


		if (transform.name == "Home")
			Application.LoadLevel ("Menu");
	}
}
