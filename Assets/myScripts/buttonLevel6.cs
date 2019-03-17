using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonLevel6 : MonoBehaviour {
	public Button animController;
	public GameObject spider1;
	public Text text;

	private Animator spider1Anim;
	private int countAnim;
	public bool mission6;
	private bool printed;
	// Use this for initialization
	void Start () {
		text.gameObject.SetActive (false);
		mission6 = false;
		countAnim = 0;
		spider1Anim = spider1.GetComponent<Animator> ();
		animController.onClick.AddListener (animDown);
		printed = false;
	}

	IEnumerator wait(){
		yield return new WaitForSeconds (2);
	}
	void animDown(){
		if (spider1.gameObject.GetComponent<Renderer> ().isVisible == true) {
			text.gameObject.SetActive (false);
			spider1Anim.Play ("jump", -1, 0f);
			countAnim++;
			StartCoroutine (wait ());
			spider1.transform.localScale+= (new Vector3 (0.002F, 0.002F, 0.002f));

			if (mission6 == true) {
				print("WELL DONE! ^_^");

				//printed = true;
			}
		} else {
			text.gameObject.SetActive (true);
			
		}
	}
		
	// Update is called once per frame
	void Update () {
		if (countAnim == 3) {
			mission6 = true;
		}

		if (spider1.gameObject.GetComponent<Renderer> ().isVisible != true) {
			text.gameObject.SetActive (true);
		}

	}
}
