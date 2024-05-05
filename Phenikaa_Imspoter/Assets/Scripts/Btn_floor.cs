using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_floor : MonoBehaviour
{
    [SerializeField] private GameObject floor_inf;
    // Start is called before the first frame update
    void Start()
    {
        floor_inf.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void On_Off_Infor(){
        floor_inf.SetActive(!floor_inf.activeSelf);
    }
    
}
