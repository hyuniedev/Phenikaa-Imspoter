using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Animator animTaskbar;
    private bool isOpenTaskbar = false;
    public void OpenDoor()
    {
        GameController.Instance.isOpenDoor = true;
        OpenTaskbar();
    }
    public void CloseDoor()
    {
        FindObjectOfType<Aite>().GetComponent<Aite>().GoOut();
        OpenTaskbar();
    }
    public void OpenTaskbar()
    {
        animTaskbar.SetInteger("openDoor", isOpenTaskbar ? -1 : 1);
        isOpenTaskbar = !isOpenTaskbar;
    }
}