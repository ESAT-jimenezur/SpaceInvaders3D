using UnityEngine;
using System.Collections;

public class ShotDestroyable : MonoBehaviour {


	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "DestroyerBullet"){
			Debug.Log ("Col!");
			Destroy(gameObject);
		}
			    
	}

}
