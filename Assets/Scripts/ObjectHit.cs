using UnityEngine;
using System.Collections;

public class ObjectHit : MonoBehaviour {
    public bool hit = false;
	public ComputerScreen screen;

    void Start()
    {
        renderer.enabled = false;
    }

    void OnMouseDown()
    {
        hit = true;
    }

	void Hit()
	{
		if (screen != null) 
		{
			if(screen.IsBad)
			{
				// good job
				// score++
				GlobalsVars.Score++;
				screen.ChooseGoodItem();
			}
			else
			{
				GlobalsVars.trys--;

				if(GlobalsVars.trys <= 0)
				{
					// Gameover
				}
			}
			// play weapon sound
			// change texture 
		}
	}
}
