using System;
using UnityEngine;

public class CheckMouse : MonoBehaviour
{
    private GameObject target;
    private void Update()
    {
        checkMouseButton();
    }
    private void checkMouseButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit2D = Physics2D.Raycast(ray, Vector2.zero, Mathf.Infinity, LayerMask.GetMask("Nimotsu"));
            if (hit2D.collider != null)
            {
                target = hit2D.collider.gameObject;
                target.AddComponent<FollowMouse>();
            }
        }
        if (Input.GetMouseButton(0))
        {

        }
        if (Input.GetMouseButtonUp(0))
        {
            if (target != null)
            {
                Destroy(target.GetComponent<FollowMouse>());
                target = null;
            }
        }
    }
}