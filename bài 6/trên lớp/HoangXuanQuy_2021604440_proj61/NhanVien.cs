using System;

public class NhanVien
{
	private string maNV;
	private string hoTen;
	private string gioiTinh;
	private string queQuan;
	private string chucVu;
	public string MaNV { get; set; }
	public string HoTen { get; set; }	
	public string GioiTinh { get; set; }
    public string QueQuan { get; set; }
	public string ChucVu { get; set; }
    public NhanVien(){}
	public NhanVien(string maNV, string hoTen, string gioiTinh, string queQuan, string chucVu)
	{
		MaNV = maNV;
		HoTen = hoTen;
		GioiTinh = gioiTinh;
		QueQuan = queQuan;
		ChucVu = chucVu;
	}
    public override string ToString()
    {
		return string.Format($"{MaNV,6}, {HoTen,20}, {GioiTinh,7}, {QueQuan,15}, {ChucVu,17}");
    }
}
