using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countTime : MonoBehaviour {

	public float timeRemaining; 
	private float keepTime;
	public bool missionAccomplished = false;
	private bool brave=true;
	public GameObject theOther;
	public Text text;
	void Start()
	{
		keepTime = timeRemaining;
		//timeRemaining = 11;
	}
	void Update()
	{
		if (!missionAccomplished) {
			if (GetComponent<Renderer> ().isVisible) {
				brave = true;
				text.gameObject.SetActive (false);
				//Debug.Log ("Inside range");
				timeRemaining -= Time.deltaTime;
				if (timeRemaining <  0 && timeRemaining >= -0.2) {//user looked ad spider for 10 constant seconds
					Debug.Log ("WELL DONE! ^_^");
					missionAccomplished = true;


				}
			} else {
				timeRemaining = keepTime;
				if (brave == true) {
					Debug.Log ("BE BRAVE! :) ");
					brave = false;
					text.gameObject.SetActive (true);
				}
			}
		}




	}
	void OnBecameInvisible() {
		//do something here
		Debug.Log("out of range!");
	}
	void OnBecameVisible(){
		Debug.Log("inside range!");
	}
}
