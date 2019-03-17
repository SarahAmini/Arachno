using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonLevel3 : MonoBehaviour {

	public Button animController;
	public GameObject spider1;
	public GameObject spider2;
	public Animator spider1Amin;
	public Animator spider2Amin;
	private int countAnim;
	public bool mission3;
	public Text text;

	// Use this for initialization
	void Start () {
		spider1Amin = spider1.GetComponent<Animator> ();
		spider2Amin = spider2.GetComponent<Animator> ();
		animController.onClick.AddListener (animDown);
		countAnim = 0;
		mission3 = false;
		text.gameObject.SetActive (false);
	}

	void animDown(){
		if (spider1.GetComponent<Renderer> ().isVisible == true && spider2.GetComponent<Renderer> ().isVisible == true) {
			text.gameObject.SetActive (false);
			int n = Random.Range (0, 2);
			print (n);
			if (n == 0) { //spider 1
				int p = Random.Range (0, 3); 
				switch (p) {
				case 0:
					spider1Amin.Play ("attack", -1, 0f);
					countAnim++;
					break;
				case 1:
					spider1Amin.Play ("jump", -1, 0f);
					countAnim++;
					break;
				case 2:
					spider1Amin.Play ("die", -1, 0f);
					countAnim++;
					break;
				}

			} else {//spider2
				int p = Random.Range (0, 3); 
				switch (p) {
				case 2:
					spider2Amin.Play ("attack", -1, 0f);
					countAnim++;
					break;
				case 0:
					spider2Amin.Play ("jump", -1, 0f);
					countAnim++;
					break;
				case 1:
					spider2Amin.Play ("die", -1, 0f);
					countAnim++;
					break;
				}
			}
			print ("+++++++++++++++++++++++++++++++++++++++");
		} else {
			print ("YOU CAN DO IT!");
		}


	}
	// Update is called once per frame
	void Update () {
		if (countAnim >= 5) {
			mission3 = true;
			//Debug.Log("WELL DONE! ^_^");
		}
		if (spider1.GetComponent<Renderer> ().isVisible != true || spider2.GetComponent<Renderer> ().isVisible != true) {
			text.gameObject.SetActive (true);
		}
		
	}
}
