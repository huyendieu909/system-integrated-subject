using System.Text;
using System.IO;
using static System.Console;
using Newtonsoft.Json;
namespace HoangXuanQuy_2021604440_proj72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            OutputEncoding = Encoding.Unicode;
            WriteLine("Thực hiện đọc ghi json vào file");
            if (!File.Exists("sinhvien.json"))
            {
                File.Create("sinhvien.json");
            }
            SerializeAListOfObject();
            DeserializeAListOfObject();
        }
        static string SerializeAListOfObject ()
        {
            List<SinhVien> sv = new List<SinhVien>();
            sv.Add(new SinhVien("sv01", "Dương Văn An", 13, "Hà Nội", "00249302934"));
            sv.Add(new SinhVien("sv02", "Nguyễn Hữu Độ", 13, "Hà Nội", "0129938437"));
            sv.Add(new SinhVien("sv03", "Ma Văn Chương", 13, "Hà Nội", "0994353954"));
            File.WriteAllText("sinhvien.json", JsonConvert.SerializeObject(sv)); 
            Clear();
            return JsonConvert.SerializeObject(sv, Formatting.Indented);
           
        }
        static void DeserializeAListOfObject ()
        {
            List<SinhVien>? sv = new List<SinhVien>();
            sv = JsonConvert.DeserializeObject<List<SinhVien>>(File.ReadAllText("sinhvien.json"));
            foreach (SinhVien s in sv)
            {
                WriteLine(s.ToString());
            }
        }

        class SinhVien
        {
            public string? MaSV { get; set; }
            public string? HoTen { get; set; }
            public int Tuoi { get; set; }
            public string? DiaChi { get; set; }
            public string? DienThoai { get; set; }
            public SinhVien(string masv, string hoten, int tuoi, string diachi, string dienthoai)
            {
                MaSV = masv;
                HoTen = hoten;
                Tuoi = tuoi;
                DiaChi = diachi;
                DienThoai = dienthoai;
            }
            public override string ToString()
            {
                return string.Format($"{MaSV, 4}, {HoTen, 32}, {Tuoi, 4}, {DiaChi, 32}, {DienThoai, 14}");
            }
        }
    }
}
