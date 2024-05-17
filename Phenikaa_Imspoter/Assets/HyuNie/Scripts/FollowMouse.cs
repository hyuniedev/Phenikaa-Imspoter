using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Animator>().enabled = false;
    }
    private void Update()
    {
        // Xu ly khi nguoi choi dung chuot ban phim
        if (Input.GetMouseButtonUp(0))
        {
            this.GetComponent<FollowMouse>().enabled = false;
        }

    }
    private void LateUpdate()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 10);
    }
}