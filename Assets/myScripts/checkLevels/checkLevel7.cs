using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLevel7 : MonoBehaviour {
	public Button mainBtn;
	private bool mission;
	private buttonLevel7 ct;
	public Button btn;
	// Use this for initialization
	void Start () {
		btn.gameObject.SetActive (false);
		ct = mainBtn.GetComponent<buttonLevel7> ();
		Debug.Log ("hey!");
	}

	// Update is called once per frame
	void FixedUpdate () {
		mission = ct.mission7;
		if (mission == true) {
			btn.gameObject.SetActive (true);
			int currentLevel = UnityEngine.PlayerPrefs.GetInt ("levelUp");
			if (currentLevel < 8) {
				UnityEngine.PlayerPrefs.SetInt ("levelUp", 8);

			}
			//Debug.Log ("hey@#!");
		}

	}
}
