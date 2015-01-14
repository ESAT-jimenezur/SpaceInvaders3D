using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	private static int current_money = 0;
	private static int total_money_earned = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static int getCurrentMoney(){
		return current_money;
	}

	public static void addMoney(int money){
		current_money = current_money + money;
		total_money_earned += money;
	}
}
