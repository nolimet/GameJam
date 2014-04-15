using UnityEngine;
using System.Collections;

public class ObjectHit : MonoBehaviour {
    public bool hit = false;
    void OnMouseDown()
    {
        hit = true;
    }
}
