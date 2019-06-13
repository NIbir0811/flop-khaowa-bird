using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public static int score,collision;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		score = 0;
		collision = 0;
		GetComponent<TextMesh>().text = " " + score;
		GameObject.Find ("GameOver").transform.position = new Vector3 (7, 2.384387f, -0.44f);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh>().text = " " + score;
		GameObject.Find ("Scoreover").GetComponent<TextMesh> ().text = "Score: " + score;

		if (Time.timeScale == 0) {
		
			GameObject.Find ("GameOver").transform.position = new Vector3 (1.69f, 2.384387f, -0.44f);
		}
	}
}
