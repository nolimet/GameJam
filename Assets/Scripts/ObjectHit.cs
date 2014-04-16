using UnityEngine;
using System.Collections;

public class ObjectHit : MonoBehaviour {
    public bool hit = false;
	public ComputerScreen screen;

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
				screen.ChooseGoodItem();
			}
			else
			{
				// Bad job
				// 1 try less
			}
			// play weapon sound
			// change texture 
		}
	}
}
