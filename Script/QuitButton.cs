#pragma strict
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using quitno;

namespace quitno{
public class QuitButton : MonoBehaviour {
	public GameObject QuitCanvas;	
	public Canvas GameOverCanvas;
	public Canvas QuitBtt;
	private SmoothFollow cam;
	//public Button Quit;

	void Start () {
		QuitCanvas.SetActive (false);
		GameOverCanvas.enabled = false;		
		cam = Camera.main.GetComponent<SmoothFollow> ();
	}

	// Update is called once per frame
	public void CanvasQuit() {
		QuitCanvas.SetActive (true);
		Time.timeScale = 0f;
		if (GameOverCanvas.enabled== true)
			GameOverCanvas.enabled = false;
			QuitBtt.enabled = false;
	}

	public void PressQuitYes() {
		Application.Quit ();
	}

	public void PressQuitNo() {
		QuitBtt.enabled = true;
		QuitCanvas.SetActive (false);
		if (GameOverCanvas.enabled == false && cam.enabled == false) { /*&& Gravity.callsound == true*/ // kiểm tra 2 điều kiện, nếu cả 2 điều kiện đúng thì mới thực hiện lệnh dưới
				GameOverCanvas.enabled = true;
		}
		Time.timeScale = 1f;
	}

	public void PressRestart() {
			QuitCanvas.SetActive (false);
			Application.LoadLevel ("SAF");
			Score.PlayAgain ();
			Time.timeScale = 1f;
	}

}
}
