using UnityEngine;
using System.Collections;

public class weapon : MonoBehaviour {
	public float DestroyTime;
	public float speed;
	
	void Start () {
		Destroy (gameObject, DestroyTime);
	}
	
	void Update(){
		this.transform.Translate (Vector3.forward * speed * Time.deltaTime);



	} 
	void OncolisionEnter(Collider other)
	{

	}
}