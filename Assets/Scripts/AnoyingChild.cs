using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnoyingChild : MonoBehaviour {

	public List<Sprite> goodStuff;
	public List<Sprite> badStuff;

	public GameObject Student;

	float timer;
	public bool IsBad { get; private set;}	

	// Use this for initialization
	void Start () {
		timer = 0.0f;
		IsBad = false;
	}
	
	// Update is called once per frame
	void Update () {
		// random actie om te doen voor een bepaalde tijd

		timer -= Time.deltaTime;
		if (timer <= 0.0f) 
		{
			Sprite newSprite = null;

			int num = Random.Range(0, 1000);
			if(num > 500)
			{
				IsBad = true;
				newSprite = badStuff[0];
				Debug.Log("Nieuwe slechte sprite");
			}
			else if(num < 900)
			{
				IsBad = false;
				newSprite = goodStuff[0];
				Debug.Log("Nieuwe goeie sprite");
			}

			SpriteRenderer sprRenderer = (SpriteRenderer)renderer;
			sprRenderer.sprite = newSprite;
			SetRandomTimer();
		}
		//Debug.Log (timer);
	}

	private void SetRandomTimer(int max = 3)
	{
		timer = Random.Range (1, max);
	}	
}