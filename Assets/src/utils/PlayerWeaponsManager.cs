using UnityEngine;
using System.Collections;

public class PlayerWeaponsManager : MonoBehaviour {

	private bool is_first_time_ = false;
	private string[] shootSounds = new string[4]{"shoot1", "shoot2", "shoot3", "shoot4"};
	private int current_weapon = 1; // 1.- Pistol


	//Weapons Settings
	//Pistol
	private float pistol_reload_time = 4.0f;
	private static int pistol_mag_count = 10;
	private static int pistol_current_mag_count = 0;
	private int pistol_reload_total_time = 3;
	private float pistol_reload_timer = 0.0f; // timer that has the time passed reloading

	
	// Use this for initialization
	void Awake () {
		int randNum = Random.Range(0, shootSounds.Length);
		
		AudioSource audio = gameObject.GetComponent("AudioSource") as AudioSource;
		audio.clip = Resources.Load("sounds/" + shootSounds[randNum]) as AudioClip;


		pistol_current_mag_count = pistol_mag_count;
	}
	
	// Update is called once per frame
	void Update () {



		switch (current_weapon){
		case 1:

			if (pistol_reload_timer > 0){ // if reloadTimer active...
				pistol_reload_timer -= Time.deltaTime; // decrement it
				Hud.isReloading(true);
				if (pistol_reload_timer <= 0){ // if reloadTime ended...
					pistol_current_mag_count = pistol_mag_count; // load a full clip...
					pistol_mag_count--; // and decrement clip count
					Hud.isReloading(false);
				}
			}else{ // only shoot when reloadTimer not active	
				if(Input.GetButtonDown("Fire1") && pistol_current_mag_count > 0){
					GameObject laserShot = Instantiate(Resources.Load("prefabs/PlayerLaserShoot"), new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
					laserShot.name = "player_laser_shot";
					laserShot.rigidbody.AddForce(transform.forward * 3000);
					audio.Play();
					pistol_current_mag_count--;
					if (pistol_current_mag_count <= 0 && pistol_mag_count > 0){
						// if run out of ammo but still have clips...
						pistol_reload_timer = pistol_reload_total_time; // activate reloadTimer
						// you can play reload sound or animation here
					}
				}
			}

			break;
		case 2:
			
			break;
		}
		
		

		/*
		if(Input.GetMouseButtonDown(0)){ // Left Click
			Shoot();
		}

		if(Input.GetMouseButtonDown(1)){ // Right Click

		}

		if(Input.GetMouseButtonDown(2)){ // Middle Click

		}
		*/
	}

	public static int getCurrentWeaponAmmo(){
		return pistol_current_mag_count;
	}

	public static int getMaxWeaponAmmo(){
		return pistol_mag_count;
	}



}
