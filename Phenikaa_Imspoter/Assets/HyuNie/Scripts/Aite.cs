using UnityEngine;
using Random = UnityEngine.Random;
public class Aite : MonoBehaviour
{
    public EObject eObject { get; set; }
    private Transform target;
    private void Start()
    {
        OnInit();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, 2.5f * Time.deltaTime);
        if (GameController.Instance.isOpenDoor)
        {
            target = GameController.Instance.getTransform(2);
            if (transform.position == target.position)
            {
                OnInit();
            }
        }
    }
    public void OnInit()
    {
        eObject = Random.Range(0, 2) == 0 ? EObject.Human : EObject.Grost;
        Debug.Log("Aite: " + eObject);
        transform.position = GameController.Instance.getTransform(0).position;
        GameController.Instance.isOpenDoor = false;
        target = GameController.Instance.getTransform(1);
    }
}