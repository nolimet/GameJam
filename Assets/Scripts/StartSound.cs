using UnityEngine;
using System.Collections;

public class StartSound : MonoBehaviour {

	public AudioClip startSound;

	bool played = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (!played) {
			audio.PlayOneShot (startSound);
			played = true;
		}
	}
}
