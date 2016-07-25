using UnityEngine;
using System.Collections;	
	public class AddPoint : MonoBehaviour {
	//public AudioSource mAudio;
	// Use this for initialization
	private SmoothFollow cam;
		void Start () {
		//mAudio.enabled = false;
		cam = Camera.main.GetComponent<SmoothFollow>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D coll) {
			if (coll.tag == "Player") {
			if (cam.enabled == true) {
			Score.AddPoint ();
			Twin.CallBackTwin (true);
			//mAudio.enabled = true;
			//mAudio.Play ();
			}
		} 
	}
}
