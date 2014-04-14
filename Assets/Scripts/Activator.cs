using UnityEngine;
using System.Collections;

public class Activator : MonoBehaviour {
    public bool State = false;
    public bool triggered = false;

    public virtual void OnDownPress()
    {
        State = true;
    }
}
