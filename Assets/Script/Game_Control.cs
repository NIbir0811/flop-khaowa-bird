using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Control : MonoBehaviour {

	public GameObject Bar;
	public float speed_bar,flag,flag1;
	public int position_y;
	// Use this for initialization
	void Start () {
		speed_bar = 3.0f;
		flag = 0;
		flag1 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Score.collision!=1)
		transform.Translate (Vector3.left * speed_bar * Time.deltaTime);

		if (transform.position.x <= 10 && flag==0) 
		{
			
			Bar_Gen();   //generating new bars
			flag=1;
		}


		if (transform.position.x <= 5 && flag1==0) 
		{
			Score.score += 1;  //calculating score

			GetComponent<AudioSource> ().Play ();
			flag1=1;
		}


		if (transform.position.x <= 3)
			Destroy (gameObject);

	}
	void Bar_Gen() //new bar clone
	{
		position_y = Random.Range (-13,-7);
		Instantiate (Bar, new Vector3 (14, position_y, 9.4704f), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}
}
