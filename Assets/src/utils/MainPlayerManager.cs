using UnityEngine;
using System.Collections;

public class MainPlayerManager : MonoBehaviour {
	

	// Update is called once per frame
	void Update () {

		if(this.gameObject.transform.position.y <= -20){
			//Player is dead, load score menu
			Application.LoadLevel("score");
		}

	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "DestroyerBullet" && other.gameObject.name != "player_laser_shot"){	
			//Player is dead, load score menu
			Application.LoadLevel("score");
		}
		
	}

}
