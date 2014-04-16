using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class weapon : MonoBehaviour {
	float DestroyTime = 1.1f;
    float speed = 0.4f;
    float startTime;
    float journeyLength;
    private Vector3 startPos;
    Transform target;

	public List<Sprite> frames;
	public int FPS = 30;
	float waitTime;
	int currentFrame;
	
    void Update()
    {
		waitTime -= Time.deltaTime;

		if (waitTime < 0) 
		{
			waitTime = 1.0f / FPS;
			currentFrame++;

			if(currentFrame >= frames.Count)
			{
				currentFrame = 0;
			}
			/*
			renderer.material.mainTexture = 

			SpriteRenderer sprRenderer = (SpriteRenderer)renderer;
			sprRenderer.sprite = frames [currentFrame];
			*/
		}

        if (target != null)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(transform.position, target.position, fracJourney);
        }



    }
    void OnCollisionEnter(Collision col)
	{
        Debug.Log("test");
        if (col.gameObject.tag == "Target")
        {
            Destroy(gameObject, DestroyTime);

			col.gameObject.SendMessage("Hit");
        }
	}

    public void getTarget(Transform _target)
    {
        target = _target;
        startPos = transform.position;
        journeyLength = Vector3.Distance(startPos, target.position);
        startTime = Time.time;
        
    }
}