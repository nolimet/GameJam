using UnityEngine;
using System.Collections;

public class BAck : MonoBehaviour {
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Escape)){
            Application.LoadLevel(0);
        }
	}
}
