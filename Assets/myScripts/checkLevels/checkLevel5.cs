using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLevel5 : MonoBehaviour {
	public Button mainBtn;
	private bool mission;
	private buttonLevel6 ct;
	public Button btn;
	// Use this for initialization
	void Start () {
		btn.gameObject.SetActive (false);
		ct = mainBtn.GetComponent<buttonLevel6> ();
		Debug.Log ("hey!");
	}

	// Update is called once per frame
	void FixedUpdate () {
		mission = ct.mission6;
		if (mission == true) {
			btn.gameObject.SetActive (true);
			int currentLevel = UnityEngine.PlayerPrefs.GetInt ("levelUp");
			if (currentLevel < 6) {
				UnityEngine.PlayerPrefs.SetInt ("levelUp", 6);

			}
			//Debug.Log ("hey@#!");
		}

	}
}
