using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController Instance
    {
        get { return instance; }
    }
    public bool isOpenDoor { get; set; } = false;
    [SerializeField] private Transform[] transforms;
    private void Awake()
    {
        instance = this;
    }
    public Transform getTransform(int index)
    {
        return transforms[index];
    }
}