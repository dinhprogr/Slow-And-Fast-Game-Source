using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Move : MonoBehaviour {
	public GameObject sphere;
	public float moveSpeed;
	public float slowspeed;	
	public Text wait_second;
	public int speedmax = 7; // tốc độ chậm cao nhất
 	public int maxspeed = 15; // tốc độ di chuyển cao nhất

	private bool pressedcanvas;
	public Canvas tap_to_play;
	static int LimitScore;

	void Start () {
	tap_to_play.enabled = true;
	wait_second.enabled = false;
	pressedcanvas = false;

	}
	public void presscanvas() {
		tap_to_play.enabled = false;
		wait_second.enabled = true;
		StartCoroutine (WaitSecond ());
	}

	void Update() {
		if (pressedcanvas) {
			if (Input.touchCount > 0) {
				sphere.transform.Translate (Vector2.right * moveSpeed * Time.deltaTime);
			} else {
				sphere.transform.Translate (Vector2.right * slowspeed * Time.deltaTime);
			}
		}
		if (LimitScore >= 20) {
			StartCoroutine (Level());
		}
	}
	IEnumerator Level() { // tăng độ khó cho game 
		if (LimitScore >= 20) { 
			slowspeed = slowspeed + 0.0003f;
			moveSpeed = moveSpeed + 0.0005f;
		}
        if (moveSpeed >= maxspeed) moveSpeed = maxspeed;
        if (slowspeed >= speedmax) slowspeed = speedmax;  
		yield return null;
	}
	IEnumerator WaitSecond(){
		wait_second.text = "3";
	yield return new WaitForSeconds (1);
		wait_second.text = "2";
	yield return new WaitForSeconds (1);
		wait_second.text = "1";
	yield return new WaitForSeconds (1);
		wait_second.enabled = false;
		pressedcanvas = true;
	}
	public static void Level_Score(int Score){
		LimitScore = Score;
	}
}



