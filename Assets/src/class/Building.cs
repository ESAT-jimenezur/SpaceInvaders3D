using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {

	public Building(){

	}


	public static void createBuilding(){

	}

	public static void createShop(float x, float y, float z){
		GameObject shop = Instantiate(Resources.Load("prefabs/Shop"), new Vector3(x, y, z), Quaternion.identity) as GameObject;
	}

}
