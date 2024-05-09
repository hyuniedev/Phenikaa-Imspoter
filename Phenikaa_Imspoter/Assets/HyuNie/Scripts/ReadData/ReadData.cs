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
    private string PATH_DATA = Application.dataPath + "/Data/data.csv";
    private string[] datas;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
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
            inforPeople.ID = long.Parse(data[0]);
            inforPeople.eObject = data[1].Equals("TRUE") ? EObject.Bot : randomEObject();
            inforPeople.Name = data[2];
        }
        else
        {
            inforPeople.Name = "Het Data";
            inforPeople.ID = 123456789;
            inforPeople.eObject = EObject.Grost;
        }
        lineIndex++;
    }
    private EObject randomEObject()
    {
        return Random.Range(0, 2) == 0 ? EObject.Human : EObject.Grost;
    }
}
