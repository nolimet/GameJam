using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(Rigidbody))]
public class thrower_driod : HitRayFirere
{
	
    public System.Collections.Generic.List<ObjectHit> targets = new System.Collections.Generic.List<ObjectHit>();

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
         //RaycastHit2D hit = new RaycastHit2D();
        if (Application.platform == RuntimePlatform.Android)
        {
            for (int i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase.Equals(TouchPhase.Began))
                {
                    Touch touch = Input.GetTouch(i);
                    RaycastHit vHit = new RaycastHit();
                    Ray vRay = Camera.main.ScreenPointToRay(touch.position);
                    if (Physics.Raycast(vRay, out vHit, 1000))
                    {
                        if (vHit.collider.name == "Target")
                        {
                            ShootBooger(vHit.collider.transform.gameObject);
                        }
                    }
                }
            }
        }
    }


	void ShootBooger(GameObject target)
	{

       GameObject bullet = Instantiate(Resources.Load("Bullet"), this.transform.position, Quaternion.Euler(0,90f,0)) as GameObject;
       bullet.GetComponent<weapon>().getTarget(target.transform);
	}
}