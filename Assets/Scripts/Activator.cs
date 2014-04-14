using UnityEngine;
using System.Collections;

public class Activator : MonoBehaviour {
    public int OpenMenuID;
    public bool Disabled;
    public bool State = false;
    public bool triggered = false;

     public virtual void OnDownPress()
    {
        if (!Disabled)
        {
            State = true;
        }
    }
}
