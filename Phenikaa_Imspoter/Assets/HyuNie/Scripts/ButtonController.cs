using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Animator animTaskbar;
    [SerializeField] private GameObject ChyuuiCard;
    private Aite aite;
    private bool isOpenTaskbar = false;
    private void Awake()
    {
        aite = FindObjectOfType<Aite>().GetComponent<Aite>();
    }
    private void Start()
    {
        ChyuuiCard.SetActive(false);
    }
    public void OpenDoor()
    {
        GameController.Instance.isOpenDoor = true;
        aite.offActiveCardID();
        OpenTaskbar();
        CheckAite(EObject.Human);
    }
    public void CloseDoor()
    {
        aite.GoOut();
        OpenTaskbar();
        CheckAite(EObject.Grost);
    }
    public void OpenTaskbar()
    {
        animTaskbar.SetInteger("openDoor", isOpenTaskbar ? -1 : 1);
        isOpenTaskbar = !isOpenTaskbar;
    }
    private void CheckAite(EObject checkEOBJ)
    {
        if (aite.eObject == EObject.Bot)
            return;
        if (aite.eObject != checkEOBJ)
        {
            ChyuuiCard.SetActive(true);
            ChyuuiCard.GetComponent<Animator>().Play("ChyuuiCard");
        }
    }
}