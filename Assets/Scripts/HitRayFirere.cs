using UnityEngine;
using System.Collections;

public class HitRayFirere : MonoBehaviour
{
    void Update()
    {
        RaycastHit2D hit = new RaycastHit2D();
        if (Application.platform == RuntimePlatform.Android)
        {
            for (int i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase.Equals(TouchPhase.Began))
                {
                    Touch touch = Input.GetTouch(i);
                    hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);

                    if (hit.collider != null)
                    {
                        hit.transform.gameObject.SendMessage("OnDownPress", SendMessageOptions.DontRequireReceiver);
                    }
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit.collider != null)
                {
                    hit.transform.gameObject.SendMessage("OnDownPress", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}