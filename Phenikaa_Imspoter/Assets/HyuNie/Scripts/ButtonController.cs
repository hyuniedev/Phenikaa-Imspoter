using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void OpenDoor()
    {
        GameController.Instance.isOpenDoor = true;
    }
    public void CloseDoor()
    {
        FindObjectOfType<Aite>().GetComponent<Aite>().OnInit();
    }
}