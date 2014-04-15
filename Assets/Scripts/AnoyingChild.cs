using UnityEngine;
using System.Collections;

public class AnoyingChild : MonoBehaviour {
	// fill them
	// Keep nothing at the end 
	enum DoingGood
	{
		Photoshop,
		D3, // 3D
		AskQuation,
		Nothing
	}

	// fill them
	// Keep nothing at the end 
	enum DoingBad
	{
		Facebook,
		Talk,
		MusicToHard,
		Eat,
		Drink,
		Gamen,
		Nothing
	}

	float timer;
	bool isBad;

	DoingBad doingBad;
	DoingGood doingGood;

	public 

	// Use this for initialization
	void Start () {
		timer = Random.Range (1, 6);
		isBad = false;
	}
	
	// Update is called once per frame
	void Update () {
		// random actie om te doen voor een bepaalde tijd

		if (timer <= 0.0f) 
		{
			if(Random.Range(0, 1000) > 500)
			{
				// bad
				isBad = true;
				doingBad = GetRandomEnum<DoingBad>(true);
				doingGood = DoingGood.Nothing;
			}
			else
			{
				// good
				isBad = false;
				doingGood = GetRandomEnum<DoingGood>(true);
				doingBad = DoingBad.Nothing;
			}

			SetRandomTimer();
		}
	}

	void OncolisionEnter(Collider other)
	{
		if (isBad) 
		{
			// add points

		} else {
			// remove point
		}
	}

	private void SetRandomTimer(int max = 5)
	{
		timer = Random.Range (1, 5);
	}

	private T GetRandomEnum<T>(bool skipLast = false)
	{
		System.Array A = System.Enum.GetValues(typeof(T));
		T V = (T)A.GetValue(UnityEngine.Random.Range(0, skipLast ? A.Length - 1 : A.Length ));
		return V;
	}
}
