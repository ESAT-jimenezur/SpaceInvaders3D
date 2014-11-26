using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private static GameManager _instance;

	public static GameManager instance{
		get{

			if(_instance == null){
				_instance = GameObject.FindObjectOfType<GameManager>();
			}
			return _instance;
		}
	}
	
	public static void init(){
		//Map creation
		Map.createMap();

		//Add player to the map
		GameObject player = Instantiate(Resources.Load("prefabs/Player"), new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity) as GameObject;
	}

	void Awake () {
		if(_instance == null){
			_instance = this;
			DontDestroyOnLoad(gameObject);
			init ();
		}else{
			Destroy(gameObject);
		}
	}

}