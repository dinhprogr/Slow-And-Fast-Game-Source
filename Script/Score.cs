using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
	static byte currentScore = 0;
	static int highScore = 0;
	static bool gov;
	// Use this for initialization
	static public void AddPoint() {
			currentScore++;
		if (currentScore > highScore) {
			highScore = currentScore;
		}
		Move.Level_Score (currentScore);
	}
	void Start(){
		highScore = PlayerPrefs.GetInt ("highScore", 0);
	}
	void OnDestroy() {
		PlayerPrefs.SetInt ("highScore", highScore);
	}
	
	// Update is called once per frame
	public Text CVScore;
	public Text CVHighScore;
	public Text GOVScore;
	public Text GOVHighScore;
	void OnGUI() {
		CVScore.text = "Score " + currentScore;
		CVHighScore.text = "High Score " + highScore;
		if (gov == true) {
			GOVScore.text = "Score " + currentScore;
			GOVHighScore.text = "High Score " + highScore;
		}
	}
	static public void PlayAgain() { // reset điểm
		currentScore = 0;
	}

	static public void CallBackGameOver(bool callback){
		gov = callback;
	}

}
