using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorgiScript : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		// press up key to walk
		// move = 6;
		//anim.SetInteger("animation", 6);

		string action = "";

		if(Input.GetKeyDown(KeyCode.Q)) {
			action = "Q";
			//print ("1");
		}
		if(Input.GetKeyDown(KeyCode.W)) {
			action = "W";
			//print ("2");
		}
		if(Input.GetKeyDown(KeyCode.E)) {
			action = "E";
			//print ("3");
		}
		if(Input.GetKeyDown(KeyCode.R)) {
			action = "R";
			//print ("4");
		}
		if(Input.GetKeyDown(KeyCode.A)) {
			action = "A";
			//print ("5s");
		}
		if(Input.GetKeyDown(KeyCode.Space)) {
			action = "O";
			//print ("5s");
		}


		switch (action) {
		case "Q":
			anim.SetInteger ("animation", 1);
			print ("Q");
			break;
		case "W":
			anim.SetInteger ("animation", 2);
			print ("W");
			break;
		case "E":
			anim.SetInteger ("animation", 3);
			print ("E");
			break;
		case "R":
			anim.SetInteger ("animation", 4);
			print ("R");
			break;
		case "A":
			anim.SetInteger ("animation", 5);
			print ("A");
			break;
		case "O":
			anim.SetInteger ("animation", 0);
			print ("idle");
			break;
			}
	}
}
