﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLevel8 : MonoBehaviour {
	public Button mainBtn;
	private bool mission;
	private buttonLevel3 ct;
	public Button btn;
	// Use this for initialization
	void Start () {
		btn.gameObject.SetActive (false);
		ct = mainBtn.GetComponent<buttonLevel3> ();
		Debug.Log ("hey!");
	}

	// Update is called once per frame
	void FixedUpdate () {
		mission = ct.mission3;
		if (mission == true) {
			btn.gameObject.SetActive (true);
			int currentLevel = UnityEngine.PlayerPrefs.GetInt ("levelUp");
			if (currentLevel < 9) {
				UnityEngine.PlayerPrefs.SetInt ("levelUp", 9);

			}
			//Debug.Log ("hey@#!");
		}

	}
}
