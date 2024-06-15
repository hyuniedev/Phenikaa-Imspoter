using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] private Text[] texts;
    //    Há» tÃªn	ID	MSV	Khoa 	Nganh hoc	Name	Sex	Address	Birth Day	Picture
    public void setTen(InforPeople info)
    {
        texts[0].text = info.Name;
    }
    public void setID(InforPeople info)
    {
        texts[0].text = info.ID.ToString();
    }
    public void setMSV(InforPeople info)
    {
        texts[0].text = info.ID.ToString();
    }
    public void setKhoa(InforPeople info)
    {
        texts[0].text = info.Name;
    }
}