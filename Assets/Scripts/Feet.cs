using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Feet : MonoBehaviour {
	public List<Sprite> frames;
	public int FPS = 10;

	int currentFrame = 0;
	float frameTime = 0.0f;
	float randomWaitTime;

	// Use this for initialization
	void Start () {
		randomWaitTime = Random.Range (0, 5);
	}
	
	// Update is called once per frame
	void Update () {
		randomWaitTime -= Time.deltaTime;
		if (randomWaitTime <= 0) 
		{
			frameTime -= Time.deltaTime;
			if (frameTime <= 0) 
			{
				frameTime = 1.0f / (float)FPS;

				currentFrame++;
				if (currentFrame >= frames.Count) {
					randomWaitTime = Random.Range(0,5);
					currentFrame = 0;
				}

				SpriteRenderer sprRenderer = (SpriteRenderer)renderer;
				sprRenderer.sprite = frames [currentFrame];
			}
		}
	}
}
