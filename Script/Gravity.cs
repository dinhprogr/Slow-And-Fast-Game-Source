using UnityEngine;
using System.Collections;
namespace quitno{
public class Gravity : MonoBehaviour {
	public GameObject sphere;
	public GameObject GameOver;
	

    public Canvas CVGameOver;
	
	public AudioSource lose;
	public bool god = false;

	static public bool callsound = false;
	private Animator gv;

	void Start () {
		CVGameOver.enabled = false;
		gv = GameOver.GetComponent<Animator> ();
		gv.enabled = false;
		//lose.enabled = false;
		if (PlayAgain.played == true) {
				callsound = false;
		}		
	}
	
	 void OnTriggerEnter2D(Collider2D col) {

		if (col.tag == "cubemin") { // nếu cột va chạm với player thì lệnh dưới xảy ra
			Camera.main.GetComponent<SmoothFollow> ().enabled = false;	
			GameOVerCanvas ();
			GameOVerSound (true);
			Score.CallBackGameOver (true);
			StopPlayer ();			
				/////
			}
			/*if (god == true) { // chế độ bất tử
				sphere.GetComponent<Rigidbody2D> ().isKinematic = true;
				Camera.main.GetComponent<SmoothFollow>().enabled = true;
				CVGameOver.enabled = false;
				callsound = false;
				GameOver.GetComponent<Animator>().enabled = false;
				lose.enabled = false;
				//lose.Play();
			}*/	
		}
		void GameOVerSound(bool onSound){
			lose.enabled = onSound;
			lose.Play ();
		}

		void StopPlayer(){
			Destroy (sphere);	
			Stop.CallBackStop (true);
		}

		void GameOVerCanvas(){
		//	Animator m_ani = GameOver.GetComponent<Animator> ();
		//	m_ani.enabled = true;
			gv.enabled = true;
			CVGameOver.enabled = true;
		}
	}
}
