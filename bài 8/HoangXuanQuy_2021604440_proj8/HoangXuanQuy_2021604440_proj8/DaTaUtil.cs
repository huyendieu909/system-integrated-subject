using System.Xml;
using System.IO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class DataUtil
{
	string filename;
	XmlElement root;
	XmlDocument doc;
	public DataUtil()
	{
		filename = "CongTy.xml";
		doc = new XmlDocument();
		if (!File.Exists(filename))
		{
			root = doc.CreateElement("congty");
			doc.AppendChild(root);
			doc.Save(filename);
		}
		doc.Load(filename);
		root = doc.DocumentElement;
	}
	public List<NhanVien> ShowStaffs()
	{
		List<NhanVien> staffs = new List<NhanVien>();
		XmlNodeList nodes = root.SelectNodes("nhanvien");
		foreach (XmlNode node in nodes)
		{
			NhanVien staff = new NhanVien
			{
				MaNV = node.Attributes["manv"].InnerText,
				HoTen = node.SelectSingleNode("hoten").InnerText,
				Tuoi = Convert.ToInt32(node.SelectSingleNode("tuoi").InnerText),
				Luong = Convert.ToInt32(node.SelectSingleNode("luong").InnerText),
				Xa = node.SelectSingleNode("diachi/xa").InnerText,
				Huyen = node.SelectSingleNode("diachi/huyen").InnerText,
				Tinh = node.SelectSingleNode("diachi/tinh").InnerText,
				DienThoai = node.SelectSingleNode("dienthoai").InnerText
			};
			staffs.Add(staff);
		}
		return staffs;
	}
	public void AddStaffs(NhanVien staff)
	{
		XmlElement nhanVien = doc.CreateElement("nhanvien");
		XmlAttribute maNV = doc.CreateAttribute("manv");
		XmlElement hoTen = doc.CreateElement("hoten");
		XmlElement tuoi = doc.CreateElement("tuoi");
		XmlElement luong = doc.CreateElement("luong");
		XmlElement diaChi = doc.CreateElement("diachi");
		XmlElement xa = doc.CreateElement("xa");
		XmlElement huyen = doc.CreateElement("huyen");
		XmlElement tinh = doc.CreateElement("tinh");
		XmlElement dienThoai = doc.CreateElement("dienthoai");

		maNV.InnerText = staff.MaNV;
		hoTen.InnerText = staff.HoTen;
		tuoi.InnerText = staff.Tuoi.ToString();
		luong.InnerText = staff.Luong.ToString();
		xa.InnerText = staff.Xa;
		huyen.InnerText = staff.Huyen;
		tinh.InnerText = staff.Tinh;
		dienThoai.InnerText = staff.DienThoai;

		diaChi.AppendChild(xa);
		diaChi.AppendChild(huyen);
		diaChi.AppendChild(tinh);
		nhanVien.Attributes.Append(maNV);
		nhanVien.AppendChild(hoTen);
		nhanVien.AppendChild(tuoi);
		nhanVien.AppendChild(luong);
		nhanVien.AppendChild(diaChi);
		nhanVien.AppendChild(dienThoai);
		root.AppendChild(nhanVien);
		doc.Save(filename);
	}
	public void DeleteStaff (string maNV)
	{
		XmlNode node = root.SelectSingleNode($"nhanvien[@manv='{maNV}']");
		if (node != null)
		{
			root.RemoveChild(node);
			doc.Save(filename);
		}
	} 
	public void EditStaff (NhanVien staff)
	{
		XmlNode node = root.SelectSingleNode($"nhanvien[@manv='{staff.MaNV}']");
		if (node != null)
		{
			node.Attributes["manv"].InnerText = staff.MaNV;
			node.SelectSingleNode("hoten").InnerText = staff.HoTen;
			node.SelectSingleNode("tuoi").InnerText = staff.Tuoi.ToString();
			node.SelectSingleNode("luong").InnerText = staff.Luong.ToString();
			node.SelectSingleNode("diachi/xa").InnerText = staff.Xa;
			node.SelectSingleNode("diachi/huyen").InnerText = staff.Huyen;
			node.SelectSingleNode("diachi/tinh").InnerText = staff.Tinh;
			node.SelectSingleNode("dienthoai").InnerText = staff.DienThoai;
			doc.Save(filename);
		}
	}
	public List<NhanVien> FindByMaNV (string maNV)
	{
		XmlNodeList nodes = root.SelectNodes($"nhanvien[@manv='{maNV}']");
		List<NhanVien> staffs = new List<NhanVien>();
		foreach (XmlNode node in nodes)
		{
            NhanVien staff = new NhanVien
            {
                MaNV = node.Attributes["manv"].InnerText,
                HoTen = node.SelectSingleNode("hoten").InnerText,
                Tuoi = Convert.ToInt32(node.SelectSingleNode("tuoi").InnerText),
                Luong = Convert.ToInt32(node.SelectSingleNode("luong").InnerText),
                Xa = node.SelectSingleNode("diachi/xa").InnerText,
                Huyen = node.SelectSingleNode("diachi/huyen").InnerText,
                Tinh = node.SelectSingleNode("diachi/tinh").InnerText,
                DienThoai = node.SelectSingleNode("dienthoai").InnerText
            };
            staffs.Add(staff);
        }
		return staffs;
	}
	public bool isExistMaNV(string maNV)
	{
		return root.SelectSingleNode($"nhanvien[@manv='{maNV}']") == null;
	}
	public int CountLuong1000(List<NhanVien> staffs)
	{
		int count = 0;
		staffs.ForEach(staff => { if (staff.Luong > 1000)  count++; });
		return count;
	}
	public int TongLuong1000(List<NhanVien> staffs)
	{        
        int sum = 0;
        staffs.ForEach(staff => { if (staff.Luong > 1000) sum+=staff.Luong; });
        return sum;
    }
}
