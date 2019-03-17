using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuHandler : MonoBehaviour {
	public void changeSeen(string sceneName){
		Application.LoadLevel (sceneName);
	}

	void Update(){
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.LoadLevel ("menu");
			}
		} else {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.LoadLevel ("menu");
			}
		}
	}
}