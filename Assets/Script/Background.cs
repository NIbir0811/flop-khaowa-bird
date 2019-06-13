using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
	public float speed_background;

	// Use this for initialization
	void Start () {
		
		speed_background = 1.0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Score.collision!=1)
		transform.Translate (Vector3.left * speed_background * Time.deltaTime);
		if(transform.localPosition.x<=-9.09f)
			transform.localPosition+= new Vector3(2*(12.21f-0),0,0);
		}
}
