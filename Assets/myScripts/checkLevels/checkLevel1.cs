using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLevel1 : MonoBehaviour {
	private GameObject spider;
	private bool mission;
	private countTime ct;
	public Button btn;
	// Use this for initialization
	void Start () {
		btn.gameObject.SetActive (false);
		spider = GameObject.Find ("spider");
		ct = spider.GetComponent<countTime> ();
		//Debug.Log ("check level");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		mission = ct.missionAccomplished;
		if (mission == true) {
			btn.gameObject.SetActive (true);
			int currentLevel = UnityEngine.PlayerPrefs.GetInt ("levelUp");
			if (currentLevel < 2) {
				UnityEngine.PlayerPrefs.SetInt ("levelUp", 2);
				Debug.Log ("level up to 2");
			}
			//Debug.Log ("hey@#!");
		}
		
	}
}
