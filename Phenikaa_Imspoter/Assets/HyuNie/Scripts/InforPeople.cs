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
    public override string ToString()
    {
        return $"TSV: {TSV}, CCCD: {CCCD}, giayDKVaoTruong: {giayDKVaoTruong}, " +
               $"veThamGiaSinhHoat: {veThamGiaSinhHoat}, veThamGiaQuanSu: {veThamGiaQuanSu}, " +
               $"giayPhepLamViec: {giayPhepLamViec}, veThamGiaHoiThao: {veThamGiaHoiThao}, " +
               $"theGiaoVien: {theGiaoVien}, phieuDuThi: {phieuDuThi}, giayDinhDangBoSung: {giayDinhDangBoSung}";
    }
}
public class InforPeople : MonoBehaviour
{
    public EObject role { get; set; }
    public long ID { get; set; }
    public string Name { get; set; }
    public string Khoa { get; set; }
    public string Nganh { get; set; }
    public string GioiTinh { get; set; }
    public string DiaChi { get; set; }
    public string dob { get; set; }
    public Identifications giayTo;
    public override string ToString()
    {
        return $"Role: {role}, ID: {ID}, Name: {Name}, Khoa: {Khoa}, Nganh: {Nganh}, " +
               $"GioiTinh: {GioiTinh}, DiaChi: {DiaChi}, DOB: {dob}, GiayTo: {giayTo}";
    }
}