#pragma strict
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnOffSound : MonoBehaviour {
	public GameObject lose;
	public GameObject through;
	public GameObject grSound;
	public Toggle onoffgr;
	int save,saved;
		
	void Start(){
		saved = PlayerPrefs.GetInt("Save",1);
		if (saved == 1) {
			lose.SetActive(true);
			through.SetActive(true);
			grSound.SetActive(true);
		}
		if (saved == 0) {
			lose.SetActive(false);
			through.SetActive(false);
			grSound.SetActive(false);
			onoffgr.isOn = false;
		}
	}
	public void OnOff() {
		if (onoffgr.isOn) {
			lose.SetActive(true);
			through.SetActive(true);
			grSound.SetActive(true);
			save = 1;
			PlayerPrefs.SetInt("Save",save);

		} else {
			lose.SetActive(false);
			through.SetActive(false);
			grSound.SetActive(false);
			save = 0;
			PlayerPrefs.SetInt("Save",save);
		} 
	}

}
