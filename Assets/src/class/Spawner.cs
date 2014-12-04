using UnityEngine;
using System.Collections;


public class Spawner : MonoBehaviour {

	
	// Use this for initialization
	void Awake () {


		for(int i = 0; i < 10; i++){
			GameObject invader = new Invader().createInvader();
			invader.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			invader.transform.Translate(GenerateRandomPos());
		}



		//GameObject[] wave = new Invader().createWave(10, 5.0f, new Vector3(50.0f, 50.0f, 50.0f));
	}

	Vector3 GenerateRandomPos(){
		float rand_x = Random.Range(-70, 70);
		float rand_y = Random.Range(20, 70);
		float rand_z = Random.Range(-70, 70);
		return new Vector3(rand_x, rand_y, rand_z);
	}


}
