using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(Rigidbody))]
public class thrower : MonoBehaviour {
	public Transform booger;

    void Start()
    {
        if (Application.platform == RuntimePlatform.WindowsWebPlayer || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {
            Debug.Log("all is oke :D this is windows");
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

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit2D hit = new RaycastHit2D();
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider != null)
                {
                    ShootBooger(hit.transform.gameObject);
                }
            }
        }
    }

	void ShootBooger(GameObject target)
	{

        GameObject bullet = Instantiate(Resources.Load("Bullet"), transform.position, Quaternion.identity) as GameObject;
       bullet.GetComponent<weapon>().getTarget(target.transform);
	}
}