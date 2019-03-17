using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
public class checkLevel14 : MonoBehaviour {
	private GameObject spider;
	private bool mission;
	private vb ct;
	public Button btn;
	// Use this for initialization
	void Start () {
		btn.gameObject.SetActive (false);
		spider = GameObject.Find ("ImageTarget");
		ct = spider.GetComponent<vb> ();
		Debug.Log ("hey!");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		mission = ct.missionAccomplished;
		if (mission == true) {
			btn.gameObject.SetActive (true);
			int currentLevel = UnityEngine.PlayerPrefs.GetInt ("levelUp");
			if (currentLevel < 15) {
				UnityEngine.PlayerPrefs.SetInt ("levelUp", 15);

			}
			//Debug.Log ("hey@#!");
		}
		
	}
}
