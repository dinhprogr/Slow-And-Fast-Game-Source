using UnityEngine;
using System.Collections;

public class Stop : MonoBehaviour {
	public GameObject StopMove;
	static bool stop;
	void Update(){
		if (stop == true) {
			StartCoroutine ("Stop_Move");
			stop = false;
		}
	}
	IEnumerator Stop_Move(){
		StopMove.GetComponent<Move> ().enabled = false;
		yield return null;
	}

	static public void CallBackStop(bool call_back){
		stop = call_back;
	}
}
