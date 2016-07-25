#pragma strict
using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {
	static byte numBGPanels = 23;

	void OnTriggerEnter2D(Collider2D col) {
		float withOfBGObj = ((BoxCollider2D)col).size.x;
		Vector3 pos = col.transform.position;
		pos.x += withOfBGObj * numBGPanels - withOfBGObj/2f;
		col.transform.position = pos;


	}
}
