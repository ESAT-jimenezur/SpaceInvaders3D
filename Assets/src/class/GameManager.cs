using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private static GameManager _instance;
	private static bool debug = false;
	public static int cube_count = 0;

	public static GameManager instance{
		get{

			if(_instance == null){
				_instance = GameObject.FindObjectOfType<GameManager>();
			}
			return _instance;
		}
	}
	
	public static void init(){

		//Reset stats
		Inventory.resetStats ();

		//Map creation
		Map.createMap();
		Building.createShop(-20.0f, 1.0f, -20.0f);

		//Add player to the map
		GameObject player = Instantiate(Resources.Load("prefabs/Player"), new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity) as GameObject;
	}

	void Awake () {
		if(_instance == null){
			_instance = this;
			//DontDestroyOnLoad(gameObject);
			init ();
		}else{
			Destroy(gameObject);
		}
	}


	void Update(){
		if(debug){
			Debug.Log(cube_count);
		}
	}

}