using UnityEngine;
using System.Collections;

public class thrower : MonoBehaviour {
	public float movementSpeed;
	public float rotationSpeed;
	
	public Transform weapon;
	
	// Update is called once per frame
	void Update () {
		float y = Input.GetAxis ("Mouse y");
		float z = Input.GetAxis ("Mouse X");
		
		transform.Translate (new Vector3 (0f, 0f, z) * movementSpeed * Time.deltaTime);
		transform.Rotate(new Vector3 (0f, y, 0f) * rotationSpeed * Time.deltaTime);
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			ShootBooger();
		}
	}
	
	void ShootBooger()
	{
		Instantiate (weapon, this.transform.position, this.transform.rotation);
	}
}