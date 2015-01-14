using UnityEngine;
using System.Collections;

public class Hud : MonoBehaviour {

	private static bool is_reloading = false;
	private Rect bullets_position = new Rect(Screen.width - 150, Screen.height - 35, 200, 80);
	private Rect money_position = new Rect(Screen.width - 150, 35, 200, 80);
	private GUIStyle gui_style = new GUIStyle();
	private Font audiowide;
	private string gui_bullets_text;


	void Awake(){
		audiowide = Resources.Load("fonts/Audiowide-Regular") as Font;
		gui_style.fontSize  = 20;
		gui_style.font = audiowide;
		gui_style.normal.textColor = Color.white;
	}

	void OnGUI() {

		if(is_reloading){
			gui_bullets_text =  "reloading";
		}else{
			gui_bullets_text = PlayerWeaponsManager.getCurrentWeaponAmmo().ToString() + " | " + PlayerWeaponsManager.getMaxWeaponAmmo();
		}

		//Show Bullets
		GUI.Label(bullets_position, gui_bullets_text,  gui_style); // Displays "10".



		//Show Money
		GUI.Label(money_position, "$" + Inventory.getCurrentMoney().ToString(), gui_style);
	}

	public static void isReloading(bool state){
		is_reloading = state;
	}

}
