using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uglyMoveCircle : MonoBehaviour {

	public Animator anim;
	public Animation animation;
	// Use this for initialization
	void Start () {
		animation = GetComponent<Animation> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * 0.2f * Time.deltaTime);
		transform.Rotate (-Vector3.up * 10f * Time.deltaTime);

			
	}
}
