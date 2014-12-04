using UnityEngine;
using System.Collections;


public class Spawner : MonoBehaviour {

	
	// Use this for initialization
	void Awake () {

		/*
		for(int i = 0; i < 10; i++){
			GameObject invader = new Invader().createInvader();
			invader.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			invader.transform.Translate(new Vector3(0.0f + (i * 2), 0.0f, 0.0f));
		}
		*/

		GameObject[] wave = new Invader().createWave(10, new Vector3(50.0f, 50.0f, 50.0f));
	}





}
