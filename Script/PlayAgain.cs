#pragma strict
using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {
	static public bool played=false;

	public void PlayAgained() {
		Application.LoadLevel ("SAF");
		Score.PlayAgain ();
		played = true;

	}
}
