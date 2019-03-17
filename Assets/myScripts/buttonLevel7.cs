using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonLevel7 : MonoBehaviour {
	public Button animController;
	public GameObject spider1;
	private Animator spider1Anim;
	private int countAnim;
	public bool mission7;
	private bool printed;
	public Text text;
	// Use this for initialization
	void Start () {
		mission7 = false;
		countAnim = 0;
		spider1Anim = spider1.GetComponent<Animator> ();
		animController.onClick.AddListener (animDown);
		printed = false;
		text.gameObject.SetActive (false);
	}

	IEnumerator wait(){
		yield return new WaitForSeconds (2);
		//spider1.transform.localScale+= (new Vector3 (0.002F, 0.002F, 0.002f));


	}
	void animDown(){
		if (spider1.gameObject.GetComponent<Renderer> ().isVisible == true) {
			spider1Anim.Play ("jump", -1, 0f);
			countAnim++;
			StartCoroutine (wait ());
			text.gameObject.SetActive (false);
				//printed = true;
		} else {
			if (mission7 != true) {
				text.gameObject.SetActive (true);
			}


		}
	}

	// Update is called once per frame
	void Update () {
		if (countAnim >= 3) {
			mission7 = true;
			text.gameObject.SetActive (false);
		}
		if (spider1.gameObject.GetComponent<Renderer> ().isVisible != true && mission7!=true) {
			text.gameObject.SetActive (true);
		}

	}
}
