using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {
    void Start()
    {
        if (Application.isEditor)
        {
            Destroy(this);
        }
    }
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
