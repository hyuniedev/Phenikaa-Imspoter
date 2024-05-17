using System;
using UnityEngine;

public struct Identifications
{
    public bool TSV;
    public bool CCCD;
    public bool giayDKVaoTruong;
    public bool veThamGiaSinhHoat;
    public bool veThamGiaQuanSu;
    public bool giayPhepLamViec;
    public bool veThamGiaHoiThao;
    public bool theGiaoVien;
    public bool phieuDuThi;
    public bool giayDinhDangBoSung;
}
public class InforPeople : MonoBehaviour
{
    public EObject eObject { get; set; }
    public int index { get; set; }
    public long ID { get; set; }
    public string Name { get; set; }
    public Identifications giayTo;
    public override string ToString()
    {
        String s = index + " " + Name + " " + ID + giayTo.TSV + " " +
        giayTo.CCCD + " " + giayTo.giayDKVaoTruong + " " +
        giayTo.veThamGiaSinhHoat + " " + giayTo.veThamGiaQuanSu + " " + giayTo.giayPhepLamViec + " " +
        giayTo.veThamGiaHoiThao + " " + giayTo.theGiaoVien + " " + giayTo.phieuDuThi + " " +
        giayTo.giayDinhDangBoSung;
        return s;
    }
}