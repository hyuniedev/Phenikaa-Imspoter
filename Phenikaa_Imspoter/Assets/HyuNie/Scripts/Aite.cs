using UnityEngine;
using Random = UnityEngine.Random;
public class Aite : MonoBehaviour
{
    [SerializeField] private GameObject CardID;
    public EObject eObject { get; set; }
    private Transform target;
    private void Start()
    {
        CardID.SetActive(false);
        OnInit();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, 2.5f * Time.deltaTime);
        CheckPerPosition();
    }
    private void CheckPerPosition()
    {
        if (GameController.Instance.isOpenDoor)
        {
            target = GameController.Instance.getTransform(2);
            if (transform.position == target.position)
            {
                OnInit();
            }
        }
        else
        {
            if (transform.position == GameController.Instance.getTransform(0).position)
            {
                OnInit();
            }
            else if (transform.position == GameController.Instance.getTransform(1).position)
            {
                ShowCard();
            }
        }
    }
    private void ShowCard()
    {
        CardID.SetActive(true);
        CardID.GetComponent<Animator>().Play("animCardID");
    }
    public void OnInit()
    {
        eObject = Random.Range(0, 2) == 0 ? EObject.Human : EObject.Grost;
        Debug.Log("Aite: " + eObject);
        transform.position = GameController.Instance.getTransform(0).position;
        GameController.Instance.isOpenDoor = false;
        target = GameController.Instance.getTransform(1);
    }
    public void GoOut()
    {
        target = GameController.Instance.getTransform(0);
        offActiveCardID();
    }
    public void offActiveCardID()
    {
        CardID.SetActive(false);
    }
}