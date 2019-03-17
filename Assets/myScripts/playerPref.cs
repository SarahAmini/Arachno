using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPref : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("levelUp");
		UnityEngine.PlayerPrefs.SetInt ("levelUp", 1);
		UnityEngine.PlayerPrefs.Save ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
