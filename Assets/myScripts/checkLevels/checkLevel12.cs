using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLevel12 : MonoBehaviour {
	private GameObject spider;
	private bool mission;
	private buttonLevel8 ct;
	public Button btn;
	// Use this for initialization
	void Start () {
		btn.gameObject.SetActive (false);
		spider = GameObject.Find ("AR");
		ct = spider.GetComponent<buttonLevel8> ();
		Debug.Log ("hey!");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		mission = ct.mission8;
		if (mission == true) {
			btn.gameObject.SetActive (true);
			int currentLevel = UnityEngine.PlayerPrefs.GetInt ("levelUp");
			if (currentLevel < 13) {
				UnityEngine.PlayerPrefs.SetInt ("levelUp", 13);

			}
			//Debug.Log ("hey@#!");
		}
		
	}
}
