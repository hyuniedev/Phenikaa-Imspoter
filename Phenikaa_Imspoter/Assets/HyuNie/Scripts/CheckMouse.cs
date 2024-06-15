using System;
using UnityEngine;

public class CheckMouse : MonoBehaviour
{
    private GameObject target;
    private Vector2 posMouse;
    private void Update()
    {
        posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        checkMouseButton();
        checkPointsMouse();
    }

    private void checkPointsMouse()
    {
        if (target == null) return;
        Vector2 posYellow = GameController.Instance.getPointMouse("Yellow");
        if (posMouse.x > posYellow.x && posMouse.y < posYellow.y)
        {
            target.gameObject.GetComponent<SpriteRenderer>().sprite = GameController.Instance.GetSprite(target.name);
            target.gameObject.transform.localScale = new Vector2(2, 2);
        }
        else
        {
            target.gameObject.GetComponent<SpriteRenderer>().sprite = GameController.Instance.GetSprite("Default");
            target.gameObject.transform.localScale = new Vector2(1, 1);
        }
    }

    private void checkMouseButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit2D = Physics2D.Raycast(posMouse, Vector2.zero, Mathf.Infinity, LayerMask.GetMask("Nimotsu"));
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