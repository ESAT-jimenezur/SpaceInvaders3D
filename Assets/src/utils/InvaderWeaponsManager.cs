using UnityEngine;
using System.Collections;

public class InvaderWeaponsManager : MonoBehaviour {

	private bool is_first_time_ = false;

	// Use this for initialization
	void Start () {
		StartCoroutine(LoadWeapons());
	}
	
	IEnumerator LoadWeapons(){
		while(true){
			yield return new WaitForSeconds(Random.Range(0, 10));
			Shoot();
		}
	}

	void Shoot(){
		SimpleProceduralCube simple_procedural_cube = ScriptableObject.CreateInstance("SimpleProceduralCube")as SimpleProceduralCube; // New way to do this, removed above!
		GameObject cube = simple_procedural_cube.createCube(new Vector3(transform.position.x, transform.position.y, transform.position.z + 2.0f), new Vector3(0.25f, 0.25f, 0.25f), "iJosShaders/cube_yellow_shader");
		cube.AddComponent<Rigidbody>();
		cube.rigidbody.AddForce(transform.forward * 5000);
	}
}
