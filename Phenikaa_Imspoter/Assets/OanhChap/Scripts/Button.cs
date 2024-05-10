using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject DenwaDisplay;
    [SerializeField] private Text textnumber;
    // Start is called before the first frame update
    void Start()
    {
        textnumber.text = "";
        DenwaDisplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickNumber(int num){
        if(textnumber.text.Length <4){
            textnumber.text += num.ToString();
        }
        
    }
    public void Delete(){
        if(textnumber.text.Length > 0){ 
            textnumber.text = textnumber.text.Substring(0,textnumber.text.Length-1);
        }
    }
    public void On(){
        DenwaDisplay.SetActive(true);
    }
    public void Off(){
        DenwaDisplay.SetActive(false);
        textnumber.text = "";
    }
    public void Call(){
        
    }
}
