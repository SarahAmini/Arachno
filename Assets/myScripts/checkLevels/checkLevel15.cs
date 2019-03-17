using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLevel15 : MonoBehaviour {
	private GameObject spider;
	private bool mission;
	private countTime ct;
	public Button btn;
	// Use this for initialization
	void Start () {
		btn.gameObject.SetActive (false);
		spider = GameObject.Find ("spider");
		ct = spider.GetComponent<countTime> ();
		Debug.Log ("hey!");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		mission = ct.missionAccomplished;
		if (mission == true) {
			btn.gameObject.SetActive (true);
			int currentLevel = UnityEngine.PlayerPrefs.GetInt ("levelUp");
			if (currentLevel < 16) {
				UnityEngine.PlayerPrefs.SetInt ("levelUp", 16);

			}
			//Debug.Log ("hey@#!");
		}
		
	}
}
