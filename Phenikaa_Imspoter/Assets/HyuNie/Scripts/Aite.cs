using UnityEngine;
public class Aite : InforPeople
{
    [SerializeField] private GameObject CardID;
    private Transform target;
    private void Start()
    {
        CardID.SetActive(false);
        OnInit();
    }
    private void Update()
    {
        if (!GameController.Instance.isCompleteDay || (!targetNotIsOne() && GameController.Instance.isCompleteDay))
            CheckPerPosition();
        transform.position = Vector3.MoveTowards(transform.position, target.position, 2.5f * Time.deltaTime);

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
            if (transform.position == GameController.Instance.getTransform(0).position && target.position == GameController.Instance.getTransform(0).position)
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
        if (target != GameController.Instance.getTransform(0))
        {
            CardID.SetActive(true);
            CardID.GetComponent<Animator>().Play("animCardID");
        }
    }
    public void OnInit()
    {
        CardID.GetComponent<Animator>().enabled = true;
        ReadData.Instance.getData(this);
        Debug.Log("eObject: " + role);
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
    public bool targetNotIsOne()
    {
        return !(target.position == GameController.Instance.getTransform(1).position);
    }
}