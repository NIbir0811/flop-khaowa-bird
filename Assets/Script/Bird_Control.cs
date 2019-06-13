using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Control : MonoBehaviour {
	public Vector3 Jumpforce;     //jumpforce for jumping
	public Rigidbody rb;        //for gravity

	// Use this for initialization
	void Start () {
		Jumpforce = new Vector3 (0, 100, 0);

		rb = GetComponent<Rigidbody> (); // to access the components
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && (Score.collision!=1)) {  // Jump with touch
			Jumpforce = new Vector3 (0, 270, 0);
			rb.velocity = Vector3.zero;
			rb.AddForce (Jumpforce);
			GetComponent<AudioSource> ().Play ();
		
		}
		else {
		
			Physics.gravity = new Vector3 (0, -19, 0);    //fall without touch 
		}

		
	}
	IEnumerator OnCollisionEnter(Collision collision)  // collision detection
	{
		Score.collision = 1;
		transform.eulerAngles = new Vector3 (0, 0, -50);
		Physics.gravity = new Vector3 (0, -30, 0);
		yield return new WaitForSeconds (1.5f);
		Time.timeScale = 0f;
		print("collision");

	}
}
