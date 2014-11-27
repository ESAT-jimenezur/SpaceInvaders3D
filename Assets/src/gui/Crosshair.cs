using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

	void Start () {
		Screen.showCursor = false;
	}

	void OnGUI(){
		GUI.Box(new Rect(Screen.width/2,Screen.height/2, 10, 10), "");
	}
	//this should be an easy fix if you are impatient :D
}
