using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class buttonLevel8 :EventTrigger {
	public bool mission8 = false;
	public Button b;
	public float timeRemaining=110f;
	public int target;
	public int done;
	// Use this for initialization
	void Start () {
		target = 3;
		done = 0;
	}

	public void keeping(){
		done++;
		if (done >= target) {
			mission8 = true;
			Debug.Log (done);
		}

	}
	public void releasing(){
	}
}
