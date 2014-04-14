using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(Rigidbody))]
public class thrower_driod : HitRayFirere
{
	
	public Transform booger;

    void Start()
    {
        if (Application.platform == RuntimePlatform.Android || Application.platform==RuntimePlatform.WP8Player)
        {
            Debug.Log("all is oke :D this is Andriod");
        }
        else
        {
            Debug.Log("notsure what this is D: I am removing my self");
            Destroy(this);
        }
    }
	// Update is called once per frame
    void Update()
    {
         RaycastHit2D hit = new RaycastHit2D();
        if (Application.platform == RuntimePlatform.Android)
        {
            for (int i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase.Equals(TouchPhase.Began))
                {
                    Touch touch = Input.GetTouch(i);
                    hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);

                    if (hit.collider != null)
                    {
                        ShootBooger(hit.transform.gameObject);
                    }
                }
            }
        }
    }


	void ShootBooger(GameObject target)
	{

       GameObject bullet = Instantiate(booger, this.transform.position, Quaternion.identity) as GameObject;
       bullet.GetComponent<weapon>().getTarget(target.transform);
	}
}