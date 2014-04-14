using UnityEngine;
using System.Collections;

public class SelectSomething : Activator{

    public int ToLoad;
    public override void OnDownPress()
    {
        base.OnDownPress();
        Application.LoadLevel(ToLoad);
        State=false;
    }
}
