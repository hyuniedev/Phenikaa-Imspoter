using System;
using System.IO;
using UnityEngine;
using Random = UnityEngine.Random;

public class ReadData : MonoBehaviour
{
    private static ReadData instance;
    public static ReadData Instance
    {
        get
        {
            return instance;
        }
    }
    private static int lineIndex;
    private string PATH_DATA_INFO = Application.dataPath + "/Data/GDD-Phenikaa-Imposter-Data.csv";
    private string PATH_DATA_CARD = Application.dataPath + "/Data/GDD-Phenikaa-Imposter-Data-1.csv";
    private string[] datas_info;
    private string[] datas_card;
    private void Awake()
    {
        instance = this;
        lineIndex = 1;
        if (!File.Exists(PATH_DATA_INFO))
        {
            File.WriteAllText(PATH_DATA_INFO, "");
        }
        if (!File.Exists(PATH_DATA_CARD))
        {
            File.WriteAllText(PATH_DATA_CARD, "");
        }
        datas_info = File.ReadAllLines(PATH_DATA_INFO);
        datas_card = File.ReadAllLines(PATH_DATA_CARD);
    }
    public void getData(InforPeople people)
    {
        string line = datas_info[lineIndex];
        if (line.Length > 0)
        {
            string[] data = line.Split(",");
            people.Name = data[1];
            people.ID = int.Parse(data[2]);
            people.Khoa = data[3];
            people.Nganh = data[4];
            people.GioiTinh = data[5];
            people.DiaChi = data[6];
            people.dob = data[7];
        }
        else
        {
            people.Name = "Het Data";
            people.ID = 123456789;
            people.role = EObject.Grost;
        }
        line = datas_card[lineIndex];
        if (line.Length > 0)
        {
            string[] data = line.Split(",");
            people.role = setRole(data[2]);
            people.giayTo.TSV = data[3].Equals("TRUE");
            people.giayTo.CCCD = data[4].Equals("TRUE");
            people.giayTo.giayDKVaoTruong = data[5].Equals("TRUE");
            people.giayTo.veThamGiaSinhHoat = data[6].Equals("TRUE");
            people.giayTo.veThamGiaQuanSu = data[7].Equals("TRUE");
            people.giayTo.giayPhepLamViec = data[8].Equals("TRUE");
            people.giayTo.veThamGiaHoiThao = data[9].Equals("TRUE");
            people.giayTo.theGiaoVien = data[10].Equals("TRUE");
            people.giayTo.phieuDuThi = data[11].Equals("TRUE");
        }
        lineIndex++;
    }
    private EObject setRole(string role)
    {
        if (role.Equals("Human"))
        {
            return EObject.Human;
        }
        else if (role.Equals("Imposter"))
        {
            return EObject.Grost;
        }
        else
        {
            return EObject.Bot;
        }
    }
}
