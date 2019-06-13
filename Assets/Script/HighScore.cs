﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("high") < Score.score) {
		
			PlayerPrefs.SetInt ("high", Score.score);
		}
		GetComponent<TextMesh> ().text = "Best: " + PlayerPrefs.GetInt ("high");
	}
}
