using UnityEngine;
using System.Collections;

public class GlobalsVars : MonoBehaviour {
	public static int Score = 0;
	public static int currentWeapon = 0;
	public static int trys = 3;

	public GUIText score;
	public GUIText tries;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + Score;
		tries.text = "Tries: " + tries;
	}
}
