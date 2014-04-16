using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(Rigidbody))]
public class thrower : MonoBehaviour {
    public System.Collections.Generic.List<ObjectHit> targets = new System.Collections.Generic.List<ObjectHit>();

    void Start()
    {
        if (Application.platform == RuntimePlatform.WindowsWebPlayer || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {
            Debug.Log("all is oke :D this is windows");
            Object[] objects = FindObjectsOfType(typeof(GameObject));
            foreach (GameObject go in objects)
            {
                if (go.tag == "Target")
                {
                    targets.Add(go.GetComponent<ObjectHit>());
                }
            }
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

       foreach(ObjectHit obj in targets){
            if (obj.hit)
            {
                obj.hit = false;
                ShootBooger(obj.transform.gameObject);
            }
        }
    }

    void ShootBooger(GameObject target)
	{

        GameObject bullet = Instantiate(Resources.Load("Bullet"), new Vector3 (transform.position.x,transform.position.y+2f,transform.position.z), Quaternion.identity) as GameObject;
       bullet.GetComponent<weapon>().getTarget(target.transform);
	}
}