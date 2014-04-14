using UnityEngine;
using System.Collections;

public class BAck : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Escape)){
            Application.LoadLevel(0);
        }
	}
}
