using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {


	public Transform target;

	void Update()
	{

	}

	void OntriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			Debug.Log(other.tag);
			target = other.transform;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			Debug.Log(other.tag);
			target = null;
		}
	}
	void OncolisionEnter(Collision other)
	{
		if (other.transform.tag == "Sphere1") 
		{
			Destroy(this.gameObject);
			Destroy(other.gameObject);
			Debug.Log ("blam boem bats");
		}
	}
}