using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject EndDay;
    private static GameController instance;
    public static GameController Instance
    {
        get { return instance; }
    }
    public bool isOpenDoor { get; set; } = false;
    public bool isCompleteDay { get; set; } = false;
    private Aite aite;
    [SerializeField] private Transform[] transforms;
    private void Awake()
    {
        aite = FindObjectOfType<Aite>();
        instance = this;
    }
    private void Start()
    {
        isCompleteDay = false;
    }
    public Transform getTransform(int index)
    {
        return transforms[index];
    }
    public void Begin_Or_End_Day()
    {
        if (isCompleteDay)
        {
            if (aite.targetNotIsOne())
                EndDay.GetComponent<Animator>().Play("off");
        }
        else
        {
            EndDay.GetComponent<Animator>().Play("on");
        }
    }
}