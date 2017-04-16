using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorgiController : MonoBehaviour {

	private InstantTrackerController trackerScript;
	private GameObject ParentButton; 
	private GameObject CorgiButton;
	//private Button SpeakButton;

	// Use this for initialization
	void Start () {

		trackerScript = GameObject.Find ("Controller").gameObject.GetComponent<InstantTrackerController> ();
		ParentButton = GameObject.Find ("Buttons Parent");
		CorgiButton = GameObject.Find("CorgiButton");
		//SpeakButton = GameObject.Find("SpeakButton");
		Debug.Log (CorgiButton);
		trackerScript._gridRenderer.enabled = false;
		CorgiButton.SetActive (false);

	}

	void OnEnable () {
		trackerScript._gridRenderer.enabled = false;
		CorgiButton.SetActive (false);
	}

	void OnDisable () {
		CorgiButton.SetActive (true);
	}

//
//	// Update is called once per frame
//	void Update () {
//		
//	}
}
