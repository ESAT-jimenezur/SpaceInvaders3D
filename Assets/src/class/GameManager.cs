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