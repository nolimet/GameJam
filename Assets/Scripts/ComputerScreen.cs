using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ComputerScreen : MonoBehaviour {

	public List<Sprite> goodStuff;
	public List<Sprite> badStuff;

	public bool IsBad { get; private set;}	

	float timer = 0.0f;

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
			int num = Random.Range(0, 1000);
			if(num > 500)
			{
				ChooseBadItem();
			}
			else if(num < 900)
			{
				ChooseGoodItem();
			}

			SetRandomTimer();
			timer -= 0.05f;
		}
		//Debug.Log (timer);
	}

	public void ChooseGoodItem()
	{
		IsBad = false;
		Sprite newSprite = goodStuff[Random.Range(0, goodStuff.Count)];
		SpriteRenderer sprRenderer = (SpriteRenderer)renderer;
		sprRenderer.sprite = newSprite;
	}

	public void ChooseBadItem()
	{
		IsBad = true;
		Sprite newSprite = badStuff[Random.Range(0, badStuff.Count)];
		SpriteRenderer sprRenderer = (SpriteRenderer)renderer;
		sprRenderer.sprite = newSprite;
	}

	private void SetRandomTimer(int max = 3)
	{
		timer = Random.Range (1, max);
	}	
}