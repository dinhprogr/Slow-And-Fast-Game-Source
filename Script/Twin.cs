using UnityEngine;
using System.Collections;

public class Twin : MonoBehaviour {
	public GameObject Player;
	public AudioSource twined;
	public AudioSource fall;
	static bool call_back_twin;
	static bool call_back_fall;
	// Use this for initialization

	void Update(){
		if (call_back_twin == true) {
			StartCoroutine ("TurnOnTwin");
			call_back_twin = false;
		} 
		if (call_back_fall == true) {
			StartCoroutine ("TurnOnFall");
			call_back_fall = false;
		}
	}
	IEnumerator TurnOnTwin(){
		twined.Play ();
		yield return null;
	}

	IEnumerator TurnOnFall(){
		fall.Play ();
		yield return null;
	}
	// Update is called once per frame
	static public void CallBackTwin(bool call){
		call_back_twin = call;
	}

	/*static public void CallBackFall(bool call){
		call_back_fall = call;
	}*/
}
