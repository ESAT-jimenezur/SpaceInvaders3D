using UnityEngine;
using System.Collections;

public class ShotDestroyable : MonoBehaviour {


	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "DestroyerBullet"){	
			GameManager.cube_count--; // Remove one cube from our counter
			if(transform.parent.name == "invader"){
				Inventory.addMoney(10); // Adding 10 dollars when destroy each block
			}
			Destroy(gameObject);
		}
			    
	}

}
