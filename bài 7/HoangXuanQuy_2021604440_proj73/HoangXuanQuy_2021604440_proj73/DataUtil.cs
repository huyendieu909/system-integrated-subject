using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Security.Principal;

public class DataUtil
{
    private string filename;
    private XmlDocument doc;
    private XmlElement root;
    public DataUtil()
    {
        filename = "NganHang.xml";
        doc = new XmlDocument();
        if (!File.Exists(filename))
        {
            root = doc.CreateElement("nganhang");
            doc.AppendChild(root);
            doc.Save(filename);
        }
        doc.Load(filename);
        root = doc.DocumentElement;
    }
    public List<TaiKhoan> ShowAccounts()
    {
        List<TaiKhoan> accounts = new List<TaiKhoan>();
        XmlNodeList nodes = root.SelectNodes("taikhoan");
        foreach (XmlNode node in nodes)
        {
            TaiKhoan account = new TaiKhoan
            {
                SoTaiKhoan = node.SelectSingleNode("sotaikhoan").InnerText,
                TenTaiKhoan = node.SelectSingleNode("tentaikhoan").InnerText,
                DiaChi = node.SelectSingleNode("diachi").InnerText,
                DienThoai = node.SelectSingleNode("dienthoai").InnerText,
                SoTien = Convert.ToInt32(node.SelectSingleNode("sotien").InnerText)
            };
            accounts.Add(account);
        }
        return accounts;
    }
    public void AddAccount(TaiKhoan account)
    {
        XmlElement taiKhoan = doc.CreateElement("taikhoan");
        XmlElement soTaiKhoan = doc.CreateElement("sotaikhoan");
        XmlElement tenTaiKhoan = doc.CreateElement("tentaikhoan");
        XmlElement diaChi = doc.CreateElement("diachi");
        XmlElement dienThoai = doc.CreateElement("dienthoai");
        XmlElement soTien = doc.CreateElement("sotien");
        taiKhoan.AppendChild(soTaiKhoan);
        taiKhoan.AppendChild(tenTaiKhoan);
        taiKhoan.AppendChild(diaChi);
        taiKhoan.AppendChild(dienThoai);
        taiKhoan.AppendChild(soTien);
        root.AppendChild(taiKhoan);
        soTaiKhoan.InnerText = account.SoTaiKhoan;
        tenTaiKhoan.InnerText = account.TenTaiKhoan;
        diaChi.InnerText = account.DiaChi;
        dienThoai.InnerText = account.DienThoai;
        soTien.InnerText = account.SoTien.ToString();
        doc.Save(filename);
    }
    public void UpdateAccount(TaiKhoan account)
    {
        XmlNode node = root.SelectSingleNode($"taikhoan[sotaikhoan='{account.SoTaiKhoan}']");
        if (node != null)
        {
            node.SelectSingleNode("sotaikhoan").InnerText = account.SoTaiKhoan;
            node.SelectSingleNode("tentaikhoan").InnerText = account.TenTaiKhoan;
            node.SelectSingleNode("diachi").InnerText = account.DiaChi;
            node.SelectSingleNode("dienthoai").InnerText = account.DienThoai;
            node.SelectSingleNode("sotien").InnerText= account.SoTien.ToString();

            doc.Save(filename);
        }
    }
    public void DeleteAccount(string soTaiKhoan)
    {
        XmlNode node = root.SelectSingleNode($"taikhoan[sotaikhoan='{soTaiKhoan}']");
        if (node != null)
        {
            root.RemoveChild(node);
        }
    }
    public List<TaiKhoan> FindAccount(string soTaiKhoan)
    {
        List<TaiKhoan> accounts = new List<TaiKhoan>();
        XmlNodeList nodes = root.SelectNodes($"taikhoan[sotaikhoan='{soTaiKhoan}']");
        foreach (XmlNode node in nodes )
        {
            TaiKhoan account = new TaiKhoan
            {
                SoTaiKhoan = node.SelectSingleNode("sotaikhoan").InnerText,
                TenTaiKhoan = node.SelectSingleNode("tentaikhoan").InnerText,
                DiaChi = node.SelectSingleNode("diachi").InnerText,
                DienThoai = node.SelectSingleNode("dienthoai").InnerText,
                SoTien = Convert.ToInt32(node.SelectSingleNode("sotien").InnerText)
            };
            accounts.Add(account);
        }
        return accounts;
    }
}
