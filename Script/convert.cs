using UnityEngine;
using System.Collections;

public class convert : MonoBehaviour {
	float[] posx;
	public GameObject[] cubes;
	// Use this for initialization
	void Start () {
		int i;
		i = Random.Range (1, 6);
		switch(i) {
		case 1:{
			posx = new float[]{35.9f,16.8f,73f,53.5f,59.5f,92.5f,109f,114f};
			break;
		}
		case 2:{
			posx = new float[]{16.8f,73f,59.5f,35.9f,92.5f,114f,109f,53.5f};
			break;
		}
		case 3:{
			posx = new float[]{35.9f,73f,16.8f,109f,114f,53.5f,59.5f,92.5f};
			break;
		}
		case 4: {
			posx = new float[]{35.9f,16.8f,59.5f,73f,109f,114f,53.5f,92.5f};
			break;
		}
		case 5:{
			posx = new float[]{73f,16.8f,35.9f,59.5f,92.5f,114f,109f,53.5f};
			break;
		}
		case 6:{
			posx = new float[]{16.8f,73f,109f,59.5f,53.5f,114f,35.9f,92.5f};
			break;
		}
		}
		for (int j = 0; j < cubes.Length; j++) {
			cubes[j].transform.position = new Vector3(posx[j],cubes[j].transform.position.y,cubes[j].transform.position.z);
		}

	} 


}