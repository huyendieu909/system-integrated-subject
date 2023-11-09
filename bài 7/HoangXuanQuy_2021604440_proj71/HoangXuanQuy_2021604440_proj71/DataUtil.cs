using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
public class DataUtil
{
    XmlDocument doc;
    XmlElement root;
    string filename;
    public DataUtil()
    {
        filename = "Nganhang.xml";
        doc = new XmlDocument();
        if (!File.Exists(filename))
        {
            XmlElement nganhang = doc.CreateElement("nganhang");
            doc.AppendChild(nganhang);
            doc.Save(filename);
        }
        doc.Load(filename);
        root = doc.DocumentElement;
    }
    public bool isExitStk(string s)
    {
        XmlNodeList afind = root.SelectNodes("taikhoan");
        int c = 0;
        foreach (XmlNode node in afind)
        {
            if (node.SelectSingleNode("sotaikhoan").InnerText == s) c++;
        }
        if (c != 0) return true;
        else return false;
    }
    public void AddTaiKhoan(TaiKhoan t)
    {
        XmlElement tk = doc.CreateElement("taikhoan");
        XmlElement stk = doc.CreateElement("sotaikhoan");
        stk.InnerText = t.soTaiKhoan;
        if (isExitStk(t.soTaiKhoan))
        {
            MessageBox.Show("So tai khoan da ton tai.", " ", MessageBoxButtons.OK);
        }
        else
        {
            XmlElement ttk = doc.CreateElement("tentaikhoan");
            ttk.InnerText = t.tenTaiKhoan;
            XmlElement dc = doc.CreateElement("diachi");
            dc.InnerText = t.diaChi;
            XmlElement dt = doc.CreateElement("dienthoai");
            dt.InnerText = t.dienThoai;
            XmlElement st = doc.CreateElement("sotien");
            st.InnerText = t.soTien;
            tk.AppendChild(stk);
            tk.AppendChild(ttk);
            tk.AppendChild(dc);
            tk.AppendChild(dt);
            tk.AppendChild(st);
            root.AppendChild(tk);
            doc.Save(filename);
        }
    }
    public bool DeleteTaiKhoan(string s)
    {
        XmlNodeList afind = root.SelectNodes("taikhoan");
        foreach (XmlNode node in afind)
        {
            if (node.SelectSingleNode("sotaikhoan").InnerText == s)
            {
                root.RemoveChild(node);
                doc.Save(filename);
                return true;
            }            
        }
        return false;
    }
    public List<TaiKhoan> GetAllTaiKhoan()
    {
        XmlNodeList nodes = root.SelectNodes("taikhoan");
        List<TaiKhoan> li = new List<TaiKhoan>();
        foreach (XmlNode node in nodes)
        {
            TaiKhoan t = new TaiKhoan();
            t.soTaiKhoan = node.SelectSingleNode("sotaikhoan").InnerText;
            t.tenTaiKhoan = node.SelectSingleNode("tentaikhoan").InnerText;
            t.diaChi = node.SelectSingleNode("diachi").InnerText;
            t.dienThoai = node.SelectSingleNode("dienthoai").InnerText;
            t.soTien = node.SelectSingleNode("sotien").InnerText;
            li.Add(t);
        }
        return li;
    }
}
