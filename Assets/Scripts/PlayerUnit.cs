using UnityEngine;
using System.Collections;
using MoonSharp.Interpreter;

public class PlayerUnit : MonoBehaviour {
	string State;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if(State == "Move"){
		//		if player clicks a moveable tile
		//		move unit there and either allow attack
		//		or end turn
		//}
	}

	void Move(){
		State = "Move";

		GameObject[] Terrains = 
			GameObject.FindGameObjectsWithTag ("Ground");
		foreach (GameObject Terrain in Terrains) {
			//if distance < UnitSpeed turn tile blue
			//and mark it as valid move
		}
	}
}
