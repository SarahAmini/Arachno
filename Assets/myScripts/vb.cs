using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class vb: MonoBehaviour, IVirtualButtonEventHandler{
	private GameObject vbo;
	private float timeRemaining = 1f;
	private float keepTime;
	public bool missionAccomplished;
	// Use this for initialization
	void Start () {
		vbo = GameObject.Find ("press");
		vbo.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		keepTime = timeRemaining;
		missionAccomplished = false;
	}

	public void  OnButtonPressed(VirtualButtonAbstractBehaviour vba){
		//Debug.Log ("555555555555555555");
		timeRemaining -= 0.34f;
		Debug.Log (timeRemaining);
		if (timeRemaining <  0) {//user looked ad spider for 10 constant seconds
			Debug.Log ("WELL DONE! ^_^");
			missionAccomplished = true;
		}

	}

	public void  OnButtonReleased(VirtualButtonAbstractBehaviour vba){

	}
	// Update is called once per frame
	void Update () {

	}
}
