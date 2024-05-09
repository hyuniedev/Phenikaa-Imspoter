using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeGameplay : MonoBehaviour
{
    [SerializeField] Text txtTime;
    private float speedTime = 5;
    private float h, m;
    private void Start()
    {
        h = 9;
        m = 0;
    }
    void Update()
    {
        m += Time.deltaTime * speedTime;
        if (m >= 60)
        {
            h++;
            m = 0;
        }
        String gio = ((int)h).ToString().Length == 1 ? "0" + (int)h : ((int)h).ToString();
        String phut = ((int)m).ToString().Length == 1 ? "0" + (int)m : ((int)m).ToString();
        txtTime.text = gio + " : " + phut;
    }
}