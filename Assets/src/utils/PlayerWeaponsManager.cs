using UnityEngine;
using System.Collections;

public class PlayerWeaponsManager : MonoBehaviour {

	private bool is_first_time_ = false;
	private string[] shootSounds = new string[4]{"shoot1", "shoot2", "shoot3", "shoot4"};
	
	// Use this for initialization
	void Start () {
		int randNum = Random.Range(0, shootSounds.Length);
		
		AudioSource audio = gameObject.GetComponent("AudioSource") as AudioSource;
		audio.clip = Resources.Load("sounds/" + shootSounds[randNum]) as AudioClip;

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){ // Left Click
			Shoot();
		}

		if(Input.GetMouseButtonDown(1)){ // Right Click

		}

		if(Input.GetMouseButtonDown(2)){ // Middle Click

		}
	}


	void Shoot(){
		GameObject laserShot = Instantiate(Resources.Load("prefabs/PlayerLaserShoot"), new Vector3(transform.position.x, transform.position.y, transform.position.z + 2.0f), Quaternion.identity) as GameObject;
		laserShot.name = "player_laser_shot";
		laserShot.rigidbody.AddForce(transform.forward * 3000);
		audio.Play();
	}

}
