using UnityEngine;
using System.Collections;

public class weapon : MonoBehaviour {
	float DestroyTime = 1.1f;
    float speed = 0.4f;
    float startTime;
    float journeyLength;
    private Vector3 startPos;
    Transform target;
	
    void Update()
    {
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