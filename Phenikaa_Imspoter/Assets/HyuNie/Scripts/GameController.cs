using System;
using System.Collections.Generic;
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
    [SerializeField] private Transform[] pointsMouse;
    private Dictionary<string, Vector2> dicPointsMouse = new Dictionary<string, Vector2>();
    private void Awake()
    {
        aite = FindObjectOfType<Aite>();
        instance = this;
    }
    private void Start()
    {
        isCompleteDay = false;
        createDictionaryPointMouse();
    }

    private void createDictionaryPointMouse()
    {
        dicPointsMouse.Add("Yellow", pointsMouse[0].position);
    }

    public Transform getTransform(int index)
    {
        return transforms[index];
    }
    public Vector2 getPointMouse(string area)
    {
        // Yellow = 0
        return dicPointsMouse[area];
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