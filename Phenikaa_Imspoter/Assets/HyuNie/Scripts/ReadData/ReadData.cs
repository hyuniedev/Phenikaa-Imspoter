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
    private string PATH_DATA = Application.dataPath + "/Data/GDD-Phenikaa-Imposter-Data.csv";
    private string[] datas;
    private void Awake()
    {
        instance = this;
        lineIndex = 1;
        Debug.Log(PATH_DATA);
        if (!File.Exists(PATH_DATA))
        {
            File.WriteAllText(PATH_DATA, "");
        }
        datas = File.ReadAllLines(PATH_DATA);
    }
    public void getData(InforPeople inforPeople)
    {
        string line = datas[lineIndex];
        if (line.Length > 0)
        {
            string[] data = line.Split(",");
            inforPeople.index = int.Parse(data[0]);
            inforPeople.Name = data[1];
            inforPeople.ID = long.Parse(data[2]);
            inforPeople.role = data[3].Trim().Equals("Special") ? EObject.Bot : (data[3].Trim().Equals("Human") ? EObject.Human : EObject.Grost);
            inforPeople.giayTo.TSV = data[4].Equals("TRUE") ? true : false;
            inforPeople.giayTo.CCCD = data[5].Equals("TRUE") ? true : false;
            inforPeople.giayTo.giayDKVaoTruong = data[6].Equals("TRUE") ? true : false;
            inforPeople.giayTo.veThamGiaSinhHoat = data[7].Equals("TRUE") ? true : false;
            inforPeople.giayTo.veThamGiaQuanSu = data[8].Equals("TRUE") ? true : false;
            inforPeople.giayTo.giayPhepLamViec = data[9].Equals("TRUE") ? true : false;
            inforPeople.giayTo.veThamGiaHoiThao = data[10].Equals("TRUE") ? true : false;
            inforPeople.giayTo.theGiaoVien = data[11].Equals("TRUE") ? true : false;
            inforPeople.giayTo.phieuDuThi = data[12].Equals("TRUE") ? true : false;
            inforPeople.giayTo.giayDinhDangBoSung = data[13].Equals("TRUE") ? true : false;
            // Debug.Log(inforPeople.ToString());
        }
        else
        {
            inforPeople.Name = "Het Data";
            inforPeople.ID = 123456789;
            inforPeople.role = EObject.Grost;
        }
        lineIndex++;
    }
}
