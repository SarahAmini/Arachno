using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelLock : MonoBehaviour
{
	public Button[] btnArray;
	bool loadLevel;
	// Use this for initialization
	void Start ()
	{
		//UnityEngine.PlayerPrefs.DeleteAll ();
		loadLevel = UnityEngine.PlayerPrefs.HasKey ("levelUp");
		Debug.Log (loadLevel);
		if (loadLevel) {
			int level = UnityEngine.PlayerPrefs.GetInt ("levelUp");
			Debug.Log (level);

			for (int i = 0; i < level; i++) {
				btnArray [i].interactable = true;
			}
		} else {
			UnityEngine.PlayerPrefs.SetInt ("levelUp",1);
			Debug.Log ("first time");
			btnArray [0].interactable = true;
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	public void Exit(){
		Application.Quit ();
	}
}

