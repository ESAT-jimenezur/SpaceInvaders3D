using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	int button_width_ = 150;
	int button_height_ = 50;

	private GUIStyle gui_style_menu = new GUIStyle();
	private GUIStyle gui_style_title = new GUIStyle();
	private Font audiowide;

	void Awake(){
		Screen.showCursor = true;

		audiowide = Resources.Load("fonts/Audiowide-Regular") as Font;
		gui_style_menu.fontSize  = 20;
		gui_style_menu.font = audiowide;
		gui_style_menu.normal.textColor = Color.white;

		gui_style_title.font = audiowide;
		gui_style_title.fontSize = 50;
		gui_style_title.normal.textColor = Color.white;
	}

	void OnGUI() {

		// Show Title

		GUI.Label(new Rect(Screen.width/3 - 50, Screen.height/6, 300, 300), "Space Invaders 3D",  gui_style_title);

		// Show Buttons

		// Game Start
		if (GUI.Button (new Rect (Screen.width/2 - button_width_/2, Screen.height/2 - button_height_/2, button_width_, button_height_), "Start Game", gui_style_menu)) {
			Debug.Log ("Starting Game");
			Application.LoadLevel("game");
		}

		//Exit
		if (GUI.Button (new Rect (Screen.width/2 - button_width_/2 + 40, Screen.height/2 - button_height_/2 + 100, button_width_, button_height_), "Exit", gui_style_menu)) {
			Application.Quit();
		}

	}
}
